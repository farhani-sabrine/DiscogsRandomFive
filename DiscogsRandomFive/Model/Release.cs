using System;
using Newtonsoft.Json;

namespace DiscogsRandomFive.Model
{
    public class Release
    {
        [JsonProperty("instance_id")]
        public int InstanceId { get; set; }

        [JsonProperty("date_added")]
        public DateTime DateAdded { get; set; }

        [JsonProperty("basic_information")]
        public BasicInformation BasicInformation { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }
    }
}
