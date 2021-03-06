using System.ComponentModel.DataAnnotations;

namespace Projet.Data.Models
{
    public class ProduitFacture
    {
        [Key]
        public string ToBeKey
        {
            get => $"{FactureId}-{ProduitId}";
            set =>  ToBeKey = value;
        }

        public virtual Facture Facture { get; set; }

        public int FactureId { get; set; }

        public virtual Produit Produit { get; set; }

        public int ProduitId { get; set; }
    }
}
