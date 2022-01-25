using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApplication1.Util
{
    public class Payload
    {
        public string channel { get; set; }
        public string username { get; set; }
        public string text { get; set; }
        public string icon_emoji { get; set; }
        public string icon_url { get; set; }
    }

    public static class Slack
    {
        public static void PostExec(string value)
        {
            var payload = new Payload
            {
                channel = "#検証",
                username = "TestApp1",
                icon_emoji = ":star:",
                text = value,
            };

            var json = JsonSerializer.Serialize(payload);

            var client = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var res = client.PostAsync("Webhook URL", content).Result;
        }
    }
}
