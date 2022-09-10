using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Helpers;
using WebApplication1.Model.DB;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly ILogger _Logger;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ILoggerFactory loggerFactory)
            : base(options)
        {
            _Logger = loggerFactory.CreateLogger("DefaultDbContext");
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // デバッグ実行時は、コードファーストが発行するSQLを、出力ウィンドウへも出力する。
            optionsBuilder.LogTo(msg => CodeFirstHelper.OutputCodeFirstLog(_Logger, msg));
        }

        public DbSet<TableA> DB_TableA { get; set; }

    }
}
