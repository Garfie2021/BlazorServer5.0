using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplication1.Data;
using WebApplication1.SharedData;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var templateFolderPath_Html = "";

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // on Windows
                FolderPath.Download = env.WebRootPath + "\\..\\Download";
                templateFolderPath_Html = env.WebRootPath + "\\..\\Template\\Html";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                // on Linux
                FolderPath.Download = env.WebRootPath + "/../Download";
            }
            else
            {
                throw new NotImplementedException();
            }

            // テンプレートファイルをstaticデータとしてアプリ起動時に読込み、キャッシュデータとして使い回すことでパフォーマンスを上げる。
            var htmlFileName = "Counter.html";
            var styleFileName = "style.html";
            TemplateData.CounterHtml = File.ReadAllText(Path.Combine(templateFolderPath_Html, htmlFileName));
            TemplateData.StyleCSS = File.ReadAllText(Path.Combine(templateFolderPath_Html, styleFileName));

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
