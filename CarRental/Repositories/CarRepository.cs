using CarRental.Models;
using CarRental.Models.CarRentalDb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _dbContext;

        private DbSet<Car> Cars { get; set; }
        public CarRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            Cars = dbContext.Cars;
        }

        public List<Car> GetAll()
        {
            return Cars.ToList();
        }
        public bool AddCar(Car cars)
        {
            Cars.Add(cars);

            return _dbContext.SaveChanges() > 0;

        }
        public Car Edit(int id, CarDto dto)
        {
            var car = Cars.Find(id);
            car.IsAvailable = dto.IsAvailable;
            car.Registration = dto.Registration;

            _dbContext.Cars.Attach(car);
            _dbContext.SaveChanges();
            return car;

        }
    }
}
