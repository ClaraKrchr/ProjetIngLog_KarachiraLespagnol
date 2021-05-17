using System;

namespace Projet.Business.DTO
{
    public class FactureListDto
    {
        public int Id { get; set; }

        public string ClientName { get; set; }

        public DateTime Date { get; set; }

        public bool Paiement { get; set; }

        public DateTime DatePaiment { get; set; }

        public int Prix { get; set; }

        public string Produits { get; set; }
    }
}
