using System.Threading.Tasks;
using Projet.Business.DTO;

namespace Projet.Business.Services
{
    public interface IClientService
    {
        Task<ClientDto> AddClient(ClientDto clientDto);
        Task<int> DeleteClient(int id);
        Task<ClientDto> GetClient(int id);
        Task<ClientDto> UpdateClient(ClientDto clientDto);
    }
}