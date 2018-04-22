using System;

namespace events.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string url { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public int StateId { get; set; }
        public string CountryId { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at {get;set;}
        public bool active { get; set; }

        public Country Country { get; set; }
        public State State { get; set; }
        
        




        

    }
}