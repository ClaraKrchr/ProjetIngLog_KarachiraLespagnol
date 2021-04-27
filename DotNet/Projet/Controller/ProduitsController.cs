using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projet.Business.DTO;
using Projet.Business.Services;

namespace Projet.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitsController : ControllerBase
    {
        private readonly IProduitService produitService;

        public ProduitsController(IProduitService service)
        {
            this.produitService = service;
        }

        //POST : api/Shops
        [HttpPost("CreateProduit")]
        public async Task<ActionResult<ProduitDto>> Create(ProduitDto dto)
        {
            try
            {
                return await this.produitService.AddProduit(dto);
            }
            catch (ArgumentNullException)
            {
                return this.ValidationProblem();
            }
            catch (Exception e)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }

        //PUT : api/shop/5
        [HttpPut("{id}/UpdateProduit")]
        public async Task<ActionResult<ProduitDto>> UpdateProduit(int id, ProduitDto dto)
        {
            if (id != dto.Id)
            {
                return this.BadRequest();
            }

            try
            {
                return await this.produitService.UpdateProduit(dto);
            }
            catch (ArgumentNullException)
            {
                return this.ValidationProblem();
            }
            catch (Exception e)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }

        //GET : api/Shop/5
        [HttpGet("{id}/Produit")]
        public async Task<ActionResult<ProduitDto>> GetProduit(int id)
        {
            if (id <= default(int))
            {
                return NotFound();
            }

            try
            {
                return await this.produitService.GetProduit(id);
            }

            catch (Exception e)
            {
                return this.StatusCode(500, "Internal Server error");
            }
        }

        [HttpGet("all/Produit")]
        public ActionResult<List<ProduitDto>> GetAllProduits()
        {
            try
            {
                return this.produitService.GetAllProduits();
            }

            catch (Exception e)
            {
                return this.StatusCode(500, "Internal Server error");
            }
        }

        //DELETE : api/Shop/5
        [HttpDelete("{id}/DeleteProduit")]
        public async Task<IActionResult> DeleteProduit(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            try
            {
                await this.produitService.DeleteProduit(id);
            }
            catch (Exception e)
            {
                return this.StatusCode(500, "Internal server error");
            }

            return NoContent();
        }
    }
}
