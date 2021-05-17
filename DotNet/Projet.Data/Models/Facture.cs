using System;
using System.Collections.Generic;

namespace Projet.Data.Models
{
    public class Facture
    {
        public int Id { get; set; }

        public virtual Client Client { get; set; }

        public int ClientId { get; set; }

        public DateTime Date { get; set; }

        public bool Paiement { get; set; }

        public DateTime DatePaiement { get; set; }

        public int Prix { get; set; }
        public virtual ICollection<ProduitFacture> ProduitFactures { get; set; }
    }
}
