using System;
using System.Collections.Generic;

namespace Projet.Business.DTO
{
    public class FactureDto
    {
        public int Id { get; set; }

        public virtual ClientDto Client { get; set; }

        public int ClientId { get; set; }

        public DateTime Date { get; set; }

        public bool Paiement { get; set; }

        public DateTime DatePaiement { get; set; }

        public int Prix { get; set; }

        public virtual ICollection<ProduitDto> Produits { get; set; }

        public DtoState DtoState { get; set; }
    }
}
