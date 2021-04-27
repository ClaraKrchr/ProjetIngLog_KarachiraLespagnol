using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Projet.Data.Models;

namespace Projet.Data.Repositories
{
    public class ProduitRepository : IProduitRepository
    {
        private readonly DataContext _context;

        public ProduitRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Produit> AddProduit(Produit produit)
        {
            _context.Produits.Add(produit);
            await _context.SaveChangesAsync();
            return produit;
        }

        public async Task<Produit> UpdateProduit(Produit produit)
        {
            _context.Produits.Update(produit);
            await _context.SaveChangesAsync();
            return produit;
        }

        public async Task<Produit> GetProduit(int id)
        {
            Produit produit = await _context.Produits.FindAsync(id);
            return produit;
        }

        public List<Produit> GetAllProduits()
        {
            List<Produit> produits = _context.Produits.ToList();
            return produits;
        }

        //public async Task<Produit> GetAllItem(Produit produit)
        //{
        //    List<Produit> produit = await _context.Produits.ToList();
        //    return produit;
        //}

        public async Task<int> DeleteProduit(int id)
        {
            Produit produit = await _context.Produits.FindAsync(id);
            _context.Remove(produit);
            return await _context.SaveChangesAsync();
        }
    }
}
