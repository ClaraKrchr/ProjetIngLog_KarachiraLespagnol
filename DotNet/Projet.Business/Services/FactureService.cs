using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet.Business.DTO;
using Projet.Data.Models;
using Projet.Data.Repositories;

namespace Projet.Business.Services
{
    public class FactureService : IFactureService
    {
        private readonly IFactureRepository factureRepository;

        public FactureService(IFactureRepository repository)
        {
            factureRepository = repository;
        }

        public async Task<FactureDto> AddFacture(FactureDto factureDto)
        {
            Facture facture = DtoToModel(factureDto);
            await factureRepository.AddFacture(facture);
            FactureDto dto = ModelToDto(facture);

            return dto;
        }

        public async Task<FactureDto> UpdateFacture(FactureDto factureDto)
        {
            Facture facture = DtoToModel(factureDto);
            await factureRepository.UpdateFacture(facture);
            FactureDto dto = ModelToDto(facture);

            return dto;
        }

        public async Task<FactureDto> GetFacture(int id)
        {
            Facture facture = await factureRepository.GetFacture(id);
            FactureDto factureDto = ModelToDto(facture);
            return factureDto;
        }

        public async Task<int> DeleteFacture(int id)
        {
            return await factureRepository.DeleteFacture(id);
        }

        private FactureDto ModelToDto(Facture facture)
        {
            FactureDto factureDto = new FactureDto
            {
                Id = facture.Id,
                ClientId = facture.ClientId,
                Date = facture.Date,
                Paiement = facture.Paiement,
                DatePaiement = facture.DatePaiement,
                Prix = facture.Prix,

                //Produits = facture.ProduitFactures.Select(p => new ProduitDto
                //{
                //    Id = p.Produit.Id,
                //    Nom = p.Produit.Nom,
                //}).ToList(),
            };

            return factureDto;
        }

        private Facture DtoToModel(FactureDto dto)
        {
            //if (entity == null)
            //{
            //    entity = new Facture();
            //}

            Facture facture = new Facture
            {
                Id = dto.Id,
                ClientId = dto.ClientId,
                Date = dto.Date,
                Paiement = dto.Paiement,
                DatePaiement = dto.DatePaiement,
                Prix = dto.Prix,

            };

            return facture;

            //entity.Id = dto.Id;
            //entity.ClientId = dto.ClientId;
            //entity.Date = dto.Date;
            //entity.Paiement = dto.Paiement;
            //entity.DatePaiement = dto.DatePaiement;
            //entity.Prix = dto.Prix;

            //if (dto.Produits?.Any() == true)
            //{
            //    foreach (var produitDto in dto.Produits.Where(x => x.DtoState == DtoState.Deleted))
            //    {
            //        var factureProduit =
            //            entity.ProduitFactures.FirstOrDefault(x =>
            //           x.ProduitId == produitDto.Id && x.FactureId == dto.Id);
            //        if (factureProduit != null)
            //        {
            //            entity.ProduitFactures.Remove(factureProduit);
            //        }
            //    }

            //    entity.ProduitFactures = entity.ProduitFactures ?? new List<ProduitFacture>();
            //    foreach (var produitDto in dto.Produits.Where(w => w.DtoState == DtoState.Added))
            //    {
            //        entity.ProduitFactures.Add(new ProduitFacture { ProduitId = produitDto.Id, FactureId = dto.Id });
            //    }
            //}
        }

        private List<FactureDto> ListModelToDto(ICollection<Facture> shopItems)
        {
            List<FactureDto> shopItemDtos = shopItems.Select(x => ModelToDto(x)).ToList();
            return shopItemDtos;
        }
    }
}
