using CarRental.Models;
using CarRental.Models.CarRentalDb;
using CarRental.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet("getAll")]
        public IActionResult Get()
        {
            var cars = _carRepository.GetAll();
            return Ok(cars);
        }
        [HttpPost("Add")]
        public IActionResult Add([FromBody] Car cars)
        {
            var carEntity = new Car
            {
                IsAvailable = cars.IsAvailable,
                Registration = cars.Registration
            };
            var result = _carRepository.AddCar(carEntity);
            if (result)
            {
                return Ok(cars);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public Car Put(int id, CarDto dto)
        {
            return _carRepository.Edit(id, dto);
        }
    }
}
