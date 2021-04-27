using System.Collections.Generic;
using System.Threading.Tasks;
using Projet.Data.Models;

namespace Projet.Data.Repositories
{
    public interface IClientRepository
    {
        Task<Client> AddClient(Client client);
        Task<int> DeleteClient(int id);
        Task<Client> GetClient(int id);
        Task<Client> UpdateClient(Client client);
        List<Client> GetAllClients();
    }
}