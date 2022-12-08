using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }    
        public string Zipcode { get; set; }
        public Geo Geo { get; set; }
    }
}
