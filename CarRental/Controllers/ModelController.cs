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
    public class ModelController : ControllerBase
    {
        private readonly IModelRepository _modelRepository;

        public ModelController(IModelRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody] ModelDto models)
        {
            var modelEntity = new Model
            {
                Brand = models.Brand,
                Capacity = models.Capacity,
                Horsepower = models.Horsepower
            };
            var result = _modelRepository.AddModel(modelEntity);
            
            return Ok(models);
            
        }
        [HttpGet("getAll")]
        public IActionResult Get()
        {
            var models = _modelRepository.GetAll();
            return Ok(models);
        }


        [HttpPut("{id}")]
        public Model Put(int id, ModelDto dto)
        {
            return _modelRepository.Edit(id, dto);
        }
    }
}
