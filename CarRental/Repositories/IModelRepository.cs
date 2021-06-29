using CarRental.Models;
using CarRental.Models.CarRentalDb;
using System.Collections.Generic;

namespace CarRental.Repositories
{
    public interface IModelRepository
    {
        Model AddModel(Model modeldto);
        Model Edit(int id, ModelDto dto);
        List<Model> GetAll();
        public Model GetModel(int id);
    }
}