using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PracticeCode2
{
    internal class HtmlHelper
    {
        private readonly static HtmlHelper _instance = new HtmlHelper();
        public static HtmlHelper Instance => _instance;
        public string [] AllTags { get; set; }
        public string [] SelfClosingTags { get; set; }
        private HtmlHelper()
        {
            string json1 = File.ReadAllText("AllTags.json");
            string json2 = File.ReadAllText("SelfClosingTags.json");
            AllTags= JsonSerializer.Deserialize<string[]>(json1);
            SelfClosingTags = JsonSerializer.Deserialize<string[]>(json2);
        }
    }
}
