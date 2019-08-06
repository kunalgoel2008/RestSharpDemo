using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpDemo.Model
{
    class Posts
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public int position_id { get; set; }
        public int organisation_id { get; set; }
        public int address_id { get; set; }
        public string mob_no { get; set; }
        public string alt_mob_no { get; set; }
        public bool isDeleted { get; set; }

    }
}
