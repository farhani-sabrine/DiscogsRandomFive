using Newtonsoft.Json;
using System.Collections.Generic;


namespace DiscogsRandomFive.Model
{
    public class Format
    {
        [JsonProperty("descriptions")]
        public List<string> Descriptions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("qty")]
        public string Qty { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
