using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class CarDto
    {

        public int Id { get; set; }

        public string Registration { get; set; }

        public bool IsAvailable { get; set; }
    }
}
