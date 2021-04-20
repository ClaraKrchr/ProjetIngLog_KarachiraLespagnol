using Projet.Data.Models;
using System.Threading.Tasks;

namespace Projet.Data.Repositories
{
    public interface IProduitRepository
    {
        Task<Produit> AddProduit(Produit produit);
        Task<int> DeleteProduit(int id);
        Task<Produit> GetProduit(int id);
        Task<Produit> UpdateProduit(Produit produit);
    }
}