using System.Threading.Tasks;
using Projet.Business.DTO;
using System.Collections.Generic;

namespace Projet.Business.Services
{
    public interface IFactureService
    {
        Task<FactureDto> AddFacture(FactureDto factureDto);
        Task<int> DeleteFacture(int id);
        Task<FactureDto> GetFacture(int id);
        List<FactureDto> GetAllFactures();
        Task<FactureDto> UpdateFacture(FactureDto factureDto);
    }
}