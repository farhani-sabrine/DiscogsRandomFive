using Newtonsoft.Json;

namespace DiscogsRandomFive.Model
{
    public class Urls
    {
        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }
}
