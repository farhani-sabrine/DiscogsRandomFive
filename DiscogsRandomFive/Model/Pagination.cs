using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscogsRandomFive.Model
{
    public class Pagination
    {
        public int Per_page { get; set; }
        public int Items { get; set; }
        public int Page { get; set; }
        public Urls Urls { get; set; }
        public int Pages { get; set; }
    }
}
