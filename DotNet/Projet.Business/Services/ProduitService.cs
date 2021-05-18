using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projet.Business.DTO;
using Projet.Data.Models;
using Projet.Data.Repositories;

namespace Projet.Business.Services
{
    public class ProduitService : IProduitService
    {
        private readonly IProduitRepository produitRepository;

        public ProduitService(IProduitRepository repository)
        {
            produitRepository = repository;
        }

        public async Task<ProduitDto> AddProduit(ProduitDto produitDto)
        {
            Produit produit = DtoToModel(produitDto);

            await produitRepository.AddProduit(produit);
            ProduitDto dto = ModelToDto(produit);

            return dto;
        }

        public async Task<ProduitDto> UpdateProduit(ProduitDto produitDto)
        {
            Produit produit = DtoToModel(produitDto);
            await produitRepository.UpdateProduit(produit);
            ProduitDto dto = ModelToDto(produit);

            return dto;
        }

        public async Task<ProduitDto> GetProduit(int id)
        {
            Produit produit = await produitRepository.GetProduit(id);
            ProduitDto produitDto = ModelToDto(produit);
            return produitDto;
        }

        public List<ProduitDto> GetAllProduits()
        {
            List<Produit> produits = produitRepository.GetAllProduits();
            List<ProduitDto> produitsDto = ListModelToDto(produits);
            return produitsDto;
        }

        public async Task<int> DeleteProduit(int id)
        {
            return await produitRepository.DeleteProduit(id);
        }

        private ProduitDto ModelToDto(Produit produit)
        {
            ProduitDto produitDto = new ProduitDto
            {
                Id = produit.Id,
                Nom = produit.Nom,
                Stock = produit.Stock,
                Photo = produit.Photo,
                Prix = produit.Prix,
            };

            return produitDto;
        }

        private Produit DtoToModel(ProduitDto dto)
        {
            Produit produit = new Produit
            {
                Id = dto.Id,
                Nom = dto.Nom,
                Stock = dto.Stock,
                Photo = dto.Photo,
                Prix = dto.Prix,
            };

            return produit;
        }

        private List<ProduitDto> ListModelToDto(ICollection<Produit> produits)
        {
            List<ProduitDto> produitDtos = produits.Select(x => ModelToDto(x)).ToList();
            return produitDtos;
        }
    }
}
