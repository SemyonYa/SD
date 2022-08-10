using Core.Models;

namespace SD2.Services
{
    public class ClientStoreService : IClient
    {
        public void Create(Client client)
        {
            throw new NotImplementedException();
        }

        public Client? Find(int id)
        {
            return new Client();
        }

        public Client? FindByToken(string token)
        {
            throw new NotImplementedException();
        }

        public void Update(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
