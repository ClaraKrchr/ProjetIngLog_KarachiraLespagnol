using System;

namespace Projet.Business.DTO
{
    public class ClientDto
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Mail { get; set; }

        public DateTime DateCreation { get; set; }
    }
}
