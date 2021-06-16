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
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderrepository;


        [HttpGet("getAll")]
        public IActionResult Get()
        {
            var orders = _orderrepository.GetAll();
            return Ok(orders);
        }

        [HttpPut("{id")]
        public Order Put(int id, OrderDto dto)
        {
            return _orderrepository.Edycja(id, dto);
        }
    }
}





