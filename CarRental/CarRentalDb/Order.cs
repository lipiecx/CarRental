using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.CarRentalDb
{
    public class Order
    {
        public int Id { get; set; }
        public virtual Client client { get; set; }

        public virtual Car car { get; set; }
        public DateTime OrderDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public double Price { get; set; }


    }
}
