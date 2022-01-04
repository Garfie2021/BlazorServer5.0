using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1.Utils
{
    public static class CopyHelper
    {
        /// <summary>
        /// オブジェクトの値コピーを容易にする拡張メソッド。
        /// </summary>
        public static T DeepCopy<T>(this T src)
        {
            var jsonSerializerOptions = new JsonSerializerOptions()
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                WriteIndented = true
            };

            var jsonData = JsonSerializer.Serialize(src, jsonSerializerOptions);

            return JsonSerializer.Deserialize<T>(jsonData, jsonSerializerOptions);
        }
    }
}
