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
    public class ProduitFactureService : IProduitFactureService
    {
        private readonly IProduitFactureRepository produitFactureRepository;

        public ProduitFactureService(IProduitFactureRepository repository)
        {
            produitFactureRepository = repository;
        }

        public async Task<ProduitFactureDto> AddProduitFacture(ProduitFactureDto produitFactureDto)
        {
            ProduitFacture produitFacture = DtoToModel(produitFactureDto);

            await produitFactureRepository.AddProduitFacture(produitFacture);
            ProduitFactureDto dto = ModelToDto(produitFacture);

            return dto;
        }

        public async Task<ProduitFactureDto> UpdateProduitFacture(ProduitFactureDto produitFactureDto)
        {
            ProduitFacture produitFacture = DtoToModel(produitFactureDto);
            await produitFactureRepository.UpdateProduitFacture(produitFacture);
            ProduitFactureDto dto = ModelToDto(produitFacture);

            return dto;
        }

        public async Task<ProduitFactureDto> GetProduitFacture(string id)
        {
            ProduitFacture produitFacture = await produitFactureRepository.GetProduitFacture(id);
            ProduitFactureDto produitFactureDto = ModelToDto(produitFacture);
            return produitFactureDto;
        }

        public async Task<int> DeleteProduitFacture(string id)
        {
            return await produitFactureRepository.DeleteProduitFacture(id);
        }

        private ProduitFactureDto ModelToDto(ProduitFacture produitFacture)
        {
            ProduitFactureDto produitFactureDto = new ProduitFactureDto
            {
                ToBeKey = produitFacture.ToBeKey,
                FactureId = produitFacture.FactureId,
                ProduitId = produitFacture.ProduitId,
            };

            return produitFactureDto;
        }

        private ProduitFacture DtoToModel(ProduitFactureDto dto)
        {
            ProduitFacture produitFacture = new ProduitFacture
            {
                ToBeKey = dto.ToBeKey,
                FactureId = dto.FactureId,
                ProduitId = dto.ProduitId,
            };

            return produitFacture;
        }

        private List<ProduitFactureDto> ListModelToDto(ICollection<ProduitFacture> shopItems)
        {
            List<ProduitFactureDto> shopItemDtos = shopItems.Select(x => ModelToDto(x)).ToList();
            return shopItemDtos;
        }
    }
}
