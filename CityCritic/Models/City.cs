using System;
namespace CityCritic.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Population { get; set; }
        public int StateId { get; set; }
    }
}
