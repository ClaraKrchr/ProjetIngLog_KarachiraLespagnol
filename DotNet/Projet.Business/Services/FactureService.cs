using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public List<FactureDto> GetAllFactures()
        {
            List<Facture> factures = factureRepository.GetAllFactures();
            List<FactureDto> facturesDto = ListModelToDto(factures);
            return facturesDto;
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

                Produits = facture.ProduitFactures.Select(p => new ProduitDto
                {
                    Id = p.ProduitId
                }).ToList(),
            };

            return factureDto;
        }

        private Facture DtoToModel(FactureDto dto)
        {
            Facture facture = new Facture
            {
                Id = dto.Id,
                ClientId = dto.ClientId,
                Date = dto.Date,
                Paiement = dto.Paiement,
                DatePaiement = dto.DatePaiement,
                Prix = dto.Prix,

            };

            if (dto.Produits?.Any() == true)
            {
                foreach (var produitDto in dto.Produits.Where(x => x.DtoState == DtoState.Deleted))
                {
                    var factureProduit =
                        facture.ProduitFactures.FirstOrDefault(x =>
                       x.ProduitId == produitDto.Id && x.FactureId == dto.Id);
                    if (factureProduit != null)
                    {
                        facture.ProduitFactures.Remove(factureProduit);
                    }
                }

                facture.ProduitFactures = facture.ProduitFactures ?? new List<ProduitFacture>();
                foreach (var produitDto in dto.Produits.Where(w => w.DtoState == DtoState.Added))
                {
                    facture.ProduitFactures.Add(new ProduitFacture { ProduitId = produitDto.Id, FactureId = dto.Id });
                }
            }

            return facture;
        }

        public Expression<Func<Facture, FactureListDto>> ModelToListDto()
        {
            return entity => new FactureListDto
            {
                Id = entity.Id,
                ClientName = entity.Client.Nom + " " + entity.Client.Prenom,
                Date = entity.Date,
                Paiement = entity.Paiement,
                DatePaiment = entity.DatePaiement,
                Prix = entity.Prix,
                Produits = string.Join(", ", entity.ProduitFactures.Select(x => x.Produit.Nom)),
            };
        }

        private List<FactureDto> ListModelToDto(ICollection<Facture> factures)
        {
            List<FactureDto> factureDtos = factures.Select(x => ModelToDto(x)).ToList();
            return factureDtos;
        }
    }
}
