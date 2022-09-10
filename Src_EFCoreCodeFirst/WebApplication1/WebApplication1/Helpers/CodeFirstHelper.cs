using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public static class CodeFirstHelper
    {
        /// <summary>
        /// EFCoreが出力するログの内、コードファーストが発行したSQLのみ、出力ウィンドウに残す。
        /// </summary>
        public static void OutputCodeFirstLog(ILogger _logger, string msg)
        {
            if (msg.IndexOf("Executing DbCommand") > -1)
            {
                Debug.WriteLine($"[Code First SQL]" + Environment.NewLine + msg);

                _logger.LogDebug($"[Code First SQL]" + Environment.NewLine + msg);
            }
        }

    }
}
