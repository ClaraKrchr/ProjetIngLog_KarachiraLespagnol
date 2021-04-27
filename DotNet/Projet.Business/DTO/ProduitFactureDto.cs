using System;
using System.Collections.Generic;
using System.Text;

namespace Projet.Business.DTO
{
    public class ProduitFactureDto
    {
        public string ToBeKey
        {
            get => $"{FactureId}-{ProduitId}";
            set => ToBeKey = value;
        }

        public virtual FactureDto Facture { get; set; }

        public int FactureId { get; set; }

        public virtual ProduitDto Produit { get; set; }

        public int ProduitId { get; set; }
    }
}
