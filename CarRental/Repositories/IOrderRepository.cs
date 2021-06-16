using CarRental.Models;
using CarRental.Models.CarRentalDb;
using System.Collections.Generic;

namespace CarRental.Repositories
{
    public interface IOrderRepository
    {
        bool Add(Order orders);
        Order Edycja(int id, OrderDto dto);
        List<Order> GetAll();
    }
}