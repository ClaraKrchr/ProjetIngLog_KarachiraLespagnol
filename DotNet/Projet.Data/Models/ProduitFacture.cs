using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Projet.Data.Models
{
    [Keyless]
    [NotMapped]
    public class ProduitFacture
    {
        public virtual Facture Facture { get; set; }

        public int FactureId { get; set; }

        public virtual Produit Produit { get; set; }

        public int ProduitId { get; set; }
    }
}
