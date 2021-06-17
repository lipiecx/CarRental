using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.CarRentalDb
{
    public class Model
    {


        public Model()
        {
            this.Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string Brand { get; set; }

        public string Capacity { get; set; }

        public int Horsepower { get; set; }


        public virtual IEnumerable<Car>? Cars{ get; set; }



    }
}
