using CarRental.Models;
using CarRental.Models.CarRentalDb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Repositories
{
    public class IModelRepositoryFake : IModelRepository
    {
        private readonly List<Model> _model;

        public IModelRepositoryFake()
        {
            _model = new List<Model>()
            {
                new Model() {Id = 1, Brand = "Honda", Capacity = "40dm^3", Horsepower = 60 },
                new Model() {Id = 2, Brand = "Honda", Capacity = "40dm^3", Horsepower = 60 },
                new Model() {Id = 3, Brand = "Honda", Capacity = "40dm^3", Horsepower = 60 }
            };
        }
        public IEnumerable<Model> GetAllItems()
        {
            return _model;
        }
        public List<Model> GetAll()
        {
            throw new NotImplementedException();
        }
        public Model AddModel(Model modeldto)
        {
            Model newmodel = new Model { Id = _model.Last().Id, Brand = modeldto.Brand, Capacity = modeldto.Capacity, Horsepower = modeldto.Horsepower };
            _model.Add(newmodel);
            return newmodel;
        }
        public Model Edit(int id, ModelDto dto)
        {
            throw new NotImplementedException();

        }

        public Model GetModel(int id)
        {
            throw new NotImplementedException();
        }
    }
}
