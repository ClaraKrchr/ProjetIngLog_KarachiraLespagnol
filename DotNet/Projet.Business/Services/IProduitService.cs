using Projet.Business.DTO;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Projet.Business.Services
{
    public interface IProduitService
    {
        Task<ProduitDto> AddProduit(ProduitDto produitDto);
        Task<int> DeleteProduit(int id);
        Task<ProduitDto> GetProduit(int id);
        List<ProduitDto> GetAllProduits();
        Task<ProduitDto> UpdateProduit(ProduitDto produitDto);
    }
}