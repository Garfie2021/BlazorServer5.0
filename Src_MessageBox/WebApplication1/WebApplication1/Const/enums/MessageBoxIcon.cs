﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
    // Windows Form アプリからコピーしたenum。
    //
    // 概要:
    //     表示する情報を定義する定数を指定します。
    public enum MessageBoxIcon
    {
        //
        // 概要:
        //     メッセージ ボックスには、シンボルが含まれていません。
        None = 0,
        //
        // 概要:
        //     メッセージ ボックスには、背景が赤い円で囲んだ白い X から成るシンボルが含まれます。
        Error = 16,
        //
        // 概要:
        //     メッセージ ボックスには、円で囲んだ疑問符から成るシンボルが含まれます。 疑問符は、質問の特定の種類を明確に表さず、メッセージの言い回しはどのメッセージの種類にも適用されるため、疑問符のメッセージ
        //     アイコンは推奨されなくなりました。 さらにユーザーは、疑問符のメッセージ シンボルをヘルプ情報と混同することがあります。 したがって、メッセージ ボックスには疑問符のメッセージ
        //     シンボルを使用しないでください。 システムは引き続き、下位互換性のためだけに、その組み込みをサポートします。
        Question = 32,
        //
        // 概要:
        //     メッセージ ボックスには、背景が黄色い三角で囲んだ感嘆符から成るシンボルが含まれます。
        Warning = 48,
        //
        // 概要:
        //     メッセージ ボックスには、円で囲んだ小文字の i から成るシンボルが含まれます。
        Information = 64
    }

}