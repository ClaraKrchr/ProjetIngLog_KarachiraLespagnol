using System.Collections.Generic;

namespace Projet.Data.Models
{
    public class Produit
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public int? Stock { get; set; }

        public string Photo { get; set; }

        public int? Prix { get; set; }

        public virtual ICollection<ProduitFacture> ProduitFactures { get; set; }
    }
}
