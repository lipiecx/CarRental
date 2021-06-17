using CarRental.Models;
using CarRental.Models.CarRentalDb;
using System.Collections.Generic;

namespace CarRental.Repositories
{
    public interface IModelRepository
    {
        bool AddModel(Model models);
        Model Edit(int id, ModelDto dto);
        List<Model> GetAll();
    }
}