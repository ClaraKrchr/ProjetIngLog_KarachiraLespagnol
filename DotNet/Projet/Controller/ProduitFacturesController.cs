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
    public class ProduitFacturesController : ControllerBase
    {
        private readonly IProduitFactureService produitFactureService;

        public ProduitFacturesController(IProduitFactureService service)
        {
            this.produitFactureService = service;
        }

        //POST : api/Shops
        [HttpPost("CreateProduitFacture")]
        public async Task<ActionResult<ProduitFactureDto>> Create(ProduitFactureDto dto)
        {
            try
            {
                return await this.produitFactureService.AddProduitFacture(dto);
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
        [HttpPut("{id}/UpdateProduitFacture")]
        public async Task<ActionResult<ProduitFactureDto>> UpdateProduitFacture(string id, ProduitFactureDto dto)
        {
            if (id != dto.ToBeKey)
            {
                return this.BadRequest();
            }

            try
            {
                return await this.produitFactureService.UpdateProduitFacture(dto);
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
        [HttpGet("{id}/ProduitFacture")]
        public async Task<ActionResult<ProduitFactureDto>> GetProduitFacture(string id)
        {
            try
            {
                return await this.produitFactureService.GetProduitFacture(id);
            }

            catch (Exception e)
            {
                return this.StatusCode(500, "Internal Server error");
            }
        }

        //DELETE : api/Shop/5
        [HttpDelete("{id}/DeleteProduitFacture")]
        public async Task<IActionResult> DeleteProduitFacture(string id)
        {
            try
            {
                await this.produitFactureService.DeleteProduitFacture(id);
            }
            catch (Exception e)
            {
                return this.StatusCode(500, "Internal server error");
            }

            return NoContent();
        }
    }
}
