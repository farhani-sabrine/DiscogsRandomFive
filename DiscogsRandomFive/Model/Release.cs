using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscogsRandomFive.Model
{
    public class Release
    {
        public int Instance_id { get; set; }
        public DateTime Date_added { get; set; }
        public BasicInformation Basic_information { get; set; }
        public int Id { get; set; }
        public int Rating { get; set; }
    }
}
