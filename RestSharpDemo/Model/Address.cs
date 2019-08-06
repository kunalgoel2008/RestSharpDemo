using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpDemo.Model
{
    class Address
    {
           public string address_type { get; internal set; }
        public int id { get; internal set; }
        public string pincode { get; internal set; }
        public int state_id { get; internal set; }
        public string street { get; internal set; }
        public string street_2 { get; internal set; }
    }
}
