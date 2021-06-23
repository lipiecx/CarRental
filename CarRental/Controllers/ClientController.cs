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
        [HttpGet("{id}")]
       
        public IActionResult Get(int id)
        {
            var client = _clientRepository.get(id);
            return Ok(client);
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody] Client client)
        {
            var clientEntity = new Client
            {
                Surename = client.Surename,
                Name = client.Name,
                Pesel = client.Pesel,
                Address = client.Address,
                Telephone = client.Telephone,
                Wallet = client.Wallet,

            };

            var result = _clientRepository.Add(clientEntity);
            if (result)
            {
                return Ok(client);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public Client Put(int id, ClientDto dto)
        {
            return _clientRepository.Edycja(id, dto);
        }
    }  
}
