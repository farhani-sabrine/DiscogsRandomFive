using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscogsRandomFive.Model
{
    public class BasicInformation
    {
        public List<Label> Labels { get; set; }
        public int Year { get; set; }
        public string Master_url { get; set; }
        public List<Artist> Artists { get; set; }
        public int Id { get; set; }
        public string Thumb { get; set; }
        public string Title { get; set; }
        public List<Format> Formats { get; set; }
        public string Cover_image { get; set; }
        public string Resource_url { get; set; }
        public int Master_id { get; set; }
    }
}
