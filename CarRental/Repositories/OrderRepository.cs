using CarRental.Models;
using CarRental.Models.CarRentalDb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _dbContext;
        private DbSet<Order> Orders { get; set; }
        public OrderRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            Orders = dbContext.Orders;

        }

        public List<Order> GetAll()
        {

            return Orders.ToList();
        }

        public bool Add(Order orders)
        {
            Orders.Add(orders);

            return _dbContext.SaveChanges() > 0;

        }

        public Order Edycja(int id, OrderDto dto)
        {

            var order = Orders.Find(id);
            order.Id = dto.Id;
            order.OrderDate = dto.OrderDate;
            order.ReturnDate = dto.ReturnDate;
            order.Price = dto.Price;



            return order;
        }


    }
}
