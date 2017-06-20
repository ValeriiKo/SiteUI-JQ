using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI_JQuery.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}
