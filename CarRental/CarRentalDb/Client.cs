using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.CarRentalDb
{
    public class Client
    {
        public Client()
        {
            this.Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public string Surename { get; set; }

        public string Name { get; set; }

        public string Pesel { get; set; }

        public string Adress { get; set; }

        public string Telephone { get; set; }

        public double Wallet { get; set; }

        public virtual IEnumerable<Order>? Orders { get; set; }
    }
}
