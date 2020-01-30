using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscogsRandomFive.Model
{
    public class BasicInformation
    {
        [JsonProperty("labels")]
        public List<Label> Labels { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("master_url")]
        public string MasterUrl { get; set; }

        [JsonProperty("artists")]
        public List<Artist> Artists { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("formats")]
        public List<Format> Formats { get; set; }

        [JsonProperty("cover_image")]
        public string CoverImage { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("master_id")]
        public int MasterId { get; set; }
    }
}
