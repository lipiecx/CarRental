using CarRental.Models;
using CarRental.Models.CarRentalDb;
using System.Collections.Generic;

namespace CarRental.Repositories
{
    public interface IClientsRepository
    {
        bool Add(Client clients);
        Client Edycja(int id, ClientDto dto);
        List<Client> GetAll();
    }
}