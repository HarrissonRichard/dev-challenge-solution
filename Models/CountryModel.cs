using System.Collections.Generic;

namespace RestCountriesChallenge.Models
{
    public class CountryModel
    {
        public FlagsModel Flags { get; set; }
        public NameModel Name { get; set; }
        public string[] Capital { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public double Area { get; set; }
        public int Population { get; set; }
        public string[] TimeZones { get; set; }



    }


}

