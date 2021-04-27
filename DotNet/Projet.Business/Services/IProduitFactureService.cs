using Projet.Business.DTO;
using System.Threading.Tasks;

namespace Projet.Business.Services
{
    public interface IProduitFactureService
    {
        Task<ProduitFactureDto> AddProduitFacture(ProduitFactureDto produitFactureDto);
        Task<int> DeleteProduitFacture(string id);
        Task<ProduitFactureDto> GetProduitFacture(string id);
        Task<ProduitFactureDto> UpdateProduitFacture(ProduitFactureDto produitFactureDto);
    }
}