using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class OrderDto
    {
        public int Id { get; set; }
        
        public int IdClient { get; set; }

        public int IdCar { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public double Price { get; set; }
    }
}