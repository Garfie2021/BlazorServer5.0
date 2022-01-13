using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Util
{
    public static class WkHtmlToImage
    {
        public static void Exec(string fileNameIn, string fileNameOut)
        {
            var command = $"wkhtmltoimage {fileNameIn} {fileNameOut}";

            using (var proc = new Process())
            {
                proc.StartInfo.FileName = "/bin/bash";
                proc.StartInfo.Arguments = "-c \" " + command + " \"";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.Start();

                proc.WaitForExit();
            }
        }
    }
}
