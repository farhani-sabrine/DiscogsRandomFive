using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscogsRandomFive.Model
{
    public class Label
    {
        public string Name { get; set; }
        public string Entity_type { get; set; }
        public string Catno { get; set; }
        public string Resource_url { get; set; }
        public int Id { get; set; }
        public string Entity_type_name { get; set; }
    }
}
