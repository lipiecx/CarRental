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
    public class ClientController : ControllerBase
    {
        private readonly IClientsRepository _clientRepository;

        public ClientController(IClientsRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpGet("getAll")]
        public IActionResult Get()
        {
            var clients = _clientRepository.GetAll();
            return Ok(clients);
        }


        [HttpPut("{id}")]
        public Client Put(int id, ClientDto dto)
        {
            return _clientRepository.Edycja(id, dto);
        }
    }  
}
