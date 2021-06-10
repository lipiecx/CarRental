using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.CarRentalDb
{
    public class Model
    {
        

        public virtual Car car { get; set; }

        public int Id { get; set; }
        public string Brand { get; set; }

        public string Capacity { get; set; }

        public int Horsepower { get; set; }

        




    }
}
