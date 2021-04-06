using System;
using System.Collections.Generic;

namespace Projet.Data.Models
{
    public class Client
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Mail { get; set; }

        public DateTime DateCreation { get; set; }

        public ICollection<Facture> Factures { get; set; }
    }
}
