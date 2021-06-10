using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.CarRentalDb
{
    public class Car
    {

        public Car()
        {
            this.Models = new HashSet<Model>();
        }
        public int Id { get; set; }

       
        public string Registration { get; set; }

        public bool IsAvailable { get; set; }
        public virtual IEnumerable<Model>? Models { get; set; }


    }
}
