using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscogsRandomFive.Model
{
    public class CollectionRelease
    {
        public Pagination Pagination { get; set; }
        public List<Release> Releases { get; set; }
    }
}
