using System;
using System.Collections.Generic;
using events.Models;

namespace events.Models
{
    public class State
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string twolettercode { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool active { get; set; }
        public int CountryId { get; set; }

        public Country Country { get; set; }

        public ICollection<Company> Companies { get; set; }
        

    }
}