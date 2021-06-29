using CarRental.Models;
using CarRental.Models.CarRentalDb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Repositories
{
    public class ModelRepository : IModelRepository
    {
        private readonly AppDbContext _dbContext;

        private DbSet<Model> Models { get; set; }
        public ModelRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            Models = dbContext.Models;
        }
        public List<Model> GetAll()
        {

            return Models.ToList();
        }
        public Model AddModel(Model modeldto)
        {
            Models.Add(modeldto);

            return modeldto;

        }
        public Model Edit(int id, ModelDto dto)
        {
            var model = Models.Find(id);
            model.Brand = dto.Brand;
            model.Capacity = dto.Capacity;
            model.Horsepower = dto.Horsepower;


            _dbContext.Models.Attach(model);
            _dbContext.SaveChanges();
            return model;

        }

        public Model GetModel(int id)
        {
            return _dbContext.Models.Find(id);
        }
    }
}
