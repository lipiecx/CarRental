using CarRental.Models;
using CarRental.Models.CarRentalDb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Repositories
{
    public class ClientsRepository : IClientsRepository
    {

        private readonly AppDbContext _dbContext;
        private DbSet<Client> Clients { get; set; }

        public ClientsRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            Clients = dbContext.Clients;
        }

        public List<Client> GetAll()
        {

            return Clients.ToList();
        }

        public bool Add(Client clients)
        {
            Clients.Add(clients);

            return _dbContext.SaveChanges() > 0;

        }

        public Client Edycja(int id, ClientDto dto)
        {

            var client = Clients.Find(id);
            client.Name = dto.Name;
            client.Surename = dto.Surename;
            client.Pesel = dto.Pesel;
            client.Wallet = dto.Wallet;
            client.Adress = dto.Adress;
            client.Telephone = dto.Telephone;

            _dbContext.Clients.Attach(client);
            _dbContext.SaveChanges();

            return client;
        }







    }
}
