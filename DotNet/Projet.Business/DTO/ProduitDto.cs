using System;
using System.Collections.Generic;
using System.Text;

namespace Projet.Business.DTO
{
    public class ProduitDto
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public int Stock { get; set; }

        public string Photo { get; set; }

        public int Prix { get; set; }

        public DtoState DtoState { get; set; }

    }
}
