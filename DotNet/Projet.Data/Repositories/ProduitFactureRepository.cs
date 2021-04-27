using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projet.Data.Models;

namespace Projet.Data.Repositories
{
    public class ProduitFactureRepository : IProduitFactureRepository
    {
        private readonly DataContext _context;

        public ProduitFactureRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ProduitFacture> AddProduitFacture(ProduitFacture produitFacture)
        {
            _context.ProduitFactures.Add(produitFacture);
            await _context.SaveChangesAsync();
            return produitFacture;
        }

        public async Task<ProduitFacture> UpdateProduitFacture(ProduitFacture produitFacture)
        {
            _context.ProduitFactures.Update(produitFacture);
            await _context.SaveChangesAsync();
            return produitFacture;
        }

        public async Task<ProduitFacture> GetProduitFacture(string id)
        {
            ProduitFacture produitFacture = await _context.ProduitFactures.FindAsync(id);
            return produitFacture;
        }

        //public async Task<ICollection<ProduitFacture>> GetAllProduitFactures()
        //{
        //    List<ProduitFacture> produitFacture = _context.ProduitFactures.ToList();
        //    return produitFacture;
        //}

        public async Task<int> DeleteProduitFacture(string id)
        {
            ProduitFacture produitFacture = await _context.ProduitFactures.FindAsync(id);
            _context.Remove(produitFacture);
            return await _context.SaveChangesAsync();
        }

        //public async Task<List<ProduitFacture>> GetAllProduitFactures(ProduitFacture produitFacture)
        //{
        //    List<ProduitFacture> produitFactures = await _context.ProduitFactures.ToList();
        //    return produitFactures;
        //}
    }
}
