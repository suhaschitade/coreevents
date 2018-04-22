using System;
using events.Models;
using System.Collections.Generic;

namespace events.Models
{
    public class Country
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string twolettercode { get; set; }
        public string threelettercode { get; set; }
        public string currency { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool active { get; set; }
        
        public ICollection<State> States { get; set; }
        public ICollection<Company> Companies { get; set; }
        
    }
}