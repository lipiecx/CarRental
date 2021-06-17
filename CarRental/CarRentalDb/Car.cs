using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.CarRentalDb
{
    public class Car
    {


        public int Id { get; set; }

        public virtual Model model { get; set; }
        public string Registration { get; set; }

        public bool IsAvailable { get; set; }
      


    }
}
