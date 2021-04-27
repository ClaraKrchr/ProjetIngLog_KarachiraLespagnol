using Projet.Data.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Projet.Data.Repositories
{
    public interface IProduitRepository
    {
        Task<Produit> AddProduit(Produit produit);
        Task<int> DeleteProduit(int id);
        Task<Produit> GetProduit(int id);
        List<Produit> GetAllProduits();
        Task<Produit> UpdateProduit(Produit produit);
    }
}