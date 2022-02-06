using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Util
{
    public static class Extension
    {

        /// <summary>
        /// Htmlタグ disabled を、簡潔に記述する為の拡張メソッド。
        /// </summary>
        public static string ToDisabled(this bool src)
        {
            return !src ? "disabled" : null;
        }

    }
}
