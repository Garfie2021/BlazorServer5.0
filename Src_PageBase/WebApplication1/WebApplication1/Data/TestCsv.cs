using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace WebApplication1.Data
{
    public class TestCsv
    {
        [Name("テスト列１")]
        public string TestClm1 { get; set; }

        [Name("テスト列２")]
        public string TestClm2 { get; set; }

        [Name("テスト列３")]
        public string TestClm3 { get; set; }
    }
}
