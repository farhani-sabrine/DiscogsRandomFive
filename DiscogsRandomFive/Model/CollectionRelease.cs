using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscogsRandomFive.Model
{
    public class CollectionRelease
    {
        [JsonProperty("pagination")]
        public Pagination Paginations { get; set; }

        [JsonProperty("releases")]
        public List<Release> Releases { get; set; }
    }
}
