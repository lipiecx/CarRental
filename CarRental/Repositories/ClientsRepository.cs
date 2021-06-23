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
         public List<ClientDto> get(int id)
    {

            List<ClientDto> list = new List<ClientDto>();
            var client = _dbContext.Clients.Where(x => x.Id == id);

            Parallel.ForEach(client, x =>

             {
                 ClientDto clientdto = new ClientDto();
                 clientdto.Name = x.Name;
                 clientdto.Surename = x.Surename;
                 clientdto.Pesel = x.Pesel;
                 clientdto.Address = x.Address;
                 clientdto.Telephone = x.Telephone;
                 clientdto.Wallet = x.Wallet;

                 list.Add(clientdto);



             });
            return list;
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
            client.Address = dto.Address;
            client.Telephone = dto.Telephone;

            _dbContext.Clients.Attach(client);
            _dbContext.SaveChanges();

            return client;
        }







    }
}
