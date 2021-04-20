using Projet.Data.Models;
using System.Threading.Tasks;

namespace Projet.Data.Repositories
{
    public interface IProduitFactureRepository
    {
        Task<ProduitFacture> AddProduitFacture(ProduitFacture produitFacture);
        Task<int> DeleteProduitFacture(string id);
        Task<ProduitFacture> GetProduitFacture(string id);
        Task<ProduitFacture> UpdateProduitFacture(ProduitFacture produitFacture);
    }
}