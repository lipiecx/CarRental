using CarRental.Models;
using CarRental.Models.CarRentalDb;
using System.Collections.Generic;

namespace CarRental.Repositories
{
    public interface IClientsRepository
    {
        List<ClientDto> get(int id);
        bool Add(Client clients);
        Client Edycja(int id, ClientDto dto);

        bool Delete(int id);
        List<Client> GetAll();
    }
}