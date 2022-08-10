using Core;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace SD2.Services
{
    public class ClientService : IClient
    {
        CoreContext context;

        public ClientService(CoreContext _context)
        {
            context = _context;
        }

        public Client? Find(int id)
        {
            return context.Clients.FirstOrDefault(c => c.Id == id);
        }

        public Client? FindByToken(string token)
        {
            return context.Clients.FirstOrDefault(c => c.Token == token);
        }

        public void Create(Client client)
        {
            context.Clients.Add(client);
            context.SaveChanges();
        }


        public void Update(Client client)
        {
            context.Clients.Update(client);
            context.SaveChanges();
        }
    }
}
