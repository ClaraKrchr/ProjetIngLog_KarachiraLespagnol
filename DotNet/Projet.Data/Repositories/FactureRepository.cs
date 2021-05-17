using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projet.Data.Models;

namespace Projet.Data.Repositories
{
    public class FactureRepository : IFactureRepository
    {
        private readonly DataContext _context;

        public FactureRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Facture> AddFacture(Facture facture)
        {
            _context.Factures.Add(facture);
            await _context.SaveChangesAsync();
            return facture;
        }

        public async Task<Facture> UpdateFacture(Facture facture)
        {
            _context.Factures.Update(facture);
            await _context.SaveChangesAsync();
            return facture;
        }

        public async Task<Facture> GetFacture(int id)
        {
            Facture facture = await _context.Factures.FindAsync(id);
            return facture;
        }

        public List<Facture> GetAllFactures()
        {
            List<Facture> factures = _context.Factures.ToList();
            return factures;
        }

        public async Task<int> DeleteFacture(int id)
        {
            Facture facture = await _context.Factures.FindAsync(id);
            _context.Remove(facture);
            return await _context.SaveChangesAsync();
        }
    }
}
