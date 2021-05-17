using System.Threading.Tasks;
using System.Collections.Generic;
using Projet.Data.Models;

namespace Projet.Data.Repositories
{
    public interface IFactureRepository
    {
        Task<Facture> AddFacture(Facture facture);
        Task<int> DeleteFacture(int id);
        Task<Facture> GetFacture(int id);
        List<Facture> GetAllFactures();
        Task<Facture> UpdateFacture(Facture facture);
    }
}