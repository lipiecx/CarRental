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
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet("getAll")]
        public IActionResult Get()
        {
            var orders = _orderRepository.GetAll();
            return Ok(orders);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] Order order)
        {
            var orderEntity = new Order
            {
                client = order.client,
                car = order.car,
                OrderDate = order.OrderDate,
                ReturnDate = order.ReturnDate,
                Price = order.Price
            };


            var result = _orderRepository.Add(orderEntity);
            if (result)
            {
                return Ok(order);
            }
            return NotFound();
        }


        [HttpPut("{id}")]
        public Order Put(int id, OrderDto dto)
        {
            return _orderRepository.Edycja(id, dto);
        }
    }
}