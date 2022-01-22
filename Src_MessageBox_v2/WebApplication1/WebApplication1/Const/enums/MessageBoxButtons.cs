using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
    // Windows Form アプリからコピーしたenum。
    //
    // 概要:
    //     表示するボタンを定義する定数を指定する System.Windows.Forms.MessageBoxです。
    public enum MessageBoxButtons
    {
        //
        // 概要:
        //     メッセージ ボックスには、[ok] ボタンが含まれています。
        OK = 0,
        //
        // 概要:
        //     メッセージ ボックスには、[ok] と [キャンセル] ボタンが含まれています。
        OKCancel = 1,
        //
        // 概要:
        //     メッセージ ボックスには、[はい] と [いいえ] ボタンが含まれています。
        YesNo = 4,
    }

}
