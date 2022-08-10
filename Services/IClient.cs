using Core.Models;

namespace SD2.Services
{
    public interface IClient
    {
        Client? Find(int id);
        Client? FindByToken(string token);
        void Create(Client client);
        void Update(Client client);

    }
}
