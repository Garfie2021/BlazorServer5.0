using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Common
{
    public static class TimeCommon
    {
        /// <summary>
        /// ニューヨークの日時
        /// </summary>
        public static int ニューヨークとの時差(DateTime dateTime)
        {
            return (GetTimeNewyork(dateTime) - GetTimeTokyo(dateTime)).Hours;
        }

        /// <summary>
        /// ニューヨークの日時
        /// </summary>
        public static DateTime GetTimeNewyork(DateTime dateTime)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(dateTime, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));
        }

        /// <summary>
        /// 東京の日時
        /// </summary>
        public static DateTime GetTimeTokyo(DateTime dateTime)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(dateTime, TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time"));
        }
    }
}
