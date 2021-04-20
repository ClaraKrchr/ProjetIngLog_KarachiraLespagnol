using System.Threading.Tasks;
using Projet.Data.Models;

namespace Projet.Data.Repositories
{
    public interface IFactureRepository
    {
        Task<Facture> AddFacture(Facture facture);
        Task<int> DeleteFacture(int id);
        Task<Facture> GetFacture(int id);
        Task<Facture> UpdateFacture(Facture facture);
    }
}