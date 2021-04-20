using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projet.Data.Models;

namespace Projet.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _context;

        public ClientRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Client> AddClient(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return client;
        }

        public async Task<Client> UpdateClient(Client client)
        {
            _context.Clients.Update(client);
            await _context.SaveChangesAsync();
            return client;
        }

        public async Task<Client> GetClient(int id)
        {
            Client client = await _context.Clients.FindAsync(id);
            return client;
        }

        public async Task<ICollection<string>> GetAllClients()
        {
            List<string> client = _context.Clients.Select(x => x.Nom).ToList();
            return client;
        }

        public async Task<int> DeleteClient(int id)
        {
            Client client = await _context.Clients.FindAsync(id);
            _context.Remove(client);
            return await _context.SaveChangesAsync();
        }
    }
}
