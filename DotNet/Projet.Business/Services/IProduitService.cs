using Projet.Business.DTO;
using System.Threading.Tasks;

namespace Projet.Business.Services
{
    public interface IProduitService
    {
        Task<ProduitDto> AddProduit(ProduitDto produitDto);
        Task<int> DeleteProduit(int id);
        Task<ProduitDto> GetProduit(int id);
        Task<ProduitDto> UpdateProduit(ProduitDto produitDto);
    }
}