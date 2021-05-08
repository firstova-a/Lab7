using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory7
{
   

   
    public class Address
    {
        public string amenity { get; set; }
        public string road { get; set; }
        public string village { get; set; }
        public string state_district { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
    }


    public class SearchJson
    {
        //public int place_id { get; set; }
        //public string licence { get; set; }
        //public string osm_type { get; set; }
       // public int osm_id { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
       // public int place_rank { get; set; }
        public string category { get; set; }
        public string type { get; set; }
        //public int importance { get; set; }
        public string addresstype { get; set; }
        public string name { get; set; }
        public string display_name { get; set; }
        public Address address { get; set; }
        public List<string> boundingbox { get; set; }

    }
}

