using CarRental.Models;
using CarRental.Models.CarRentalDb;
using System.Collections.Generic;

namespace CarRental.Repositories
{
    public interface ICarRepository
    {
        bool AddCar(Car cars);
        Car Edit(int id, CarDto dto);
        List<Car> GetAll();
    }
}