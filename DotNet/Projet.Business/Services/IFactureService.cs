using System.Threading.Tasks;
using Projet.Business.DTO;
using Projet.Data.Models;

namespace Projet.Business.Services
{
    public interface IFactureService
    {
        Task<FactureDto> AddFacture(FactureDto factureDto);
        Task<int> DeleteFacture(int id);
        Task<FactureDto> GetFacture(int id);
        Task<FactureDto> UpdateFacture(FactureDto factureDto);
    }
}