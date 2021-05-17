using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projet.Business.DTO;
using Projet.Business.Services;

namespace Projet.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturesController : ControllerBase
    {
        private readonly IFactureService factureService;

        public FacturesController(IFactureService service)
        {
            this.factureService = service;
        }

        // POST : api/Factures
        [HttpPost("CreateFacture")]
        public async Task<ActionResult<FactureDto>> Create(FactureDto dto)
        {
            try
            {
                return await this.factureService.AddFacture(dto);
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

        // PUT : api/facture/5
        [HttpPut("{id}/UpdateFacture")]
        public async Task<ActionResult<FactureDto>> UpdateFacture(int id, FactureDto dto)
        {
            if (id != dto.Id)
            {
                return this.BadRequest();
            }

            try
            {
                return await this.factureService.UpdateFacture(dto);
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

        //GET : api/Facture/5
        [HttpGet("{id}/Facture")]
        public async Task<ActionResult<FactureDto>> GetFacture(int id)
        {
            if (id <= default(int))
            {
                return NotFound();
            }

            try
            {
                return await this.factureService.GetFacture(id);
            }

            catch (Exception e)
            {
                return this.StatusCode(500, "Internal Server error");
            }
        }

        [HttpGet("all/Facture")]
        public ActionResult<List<FactureDto>> GetAllFactures()
        {
            try
            {
                return this.factureService.GetAllFactures();
            }

            catch (Exception e)
            {
                return this.StatusCode(500, "Internal Server error");
            }
        }

        //DELETE : api/Facture/5
        [HttpDelete("{id}/DeleteFacture")]
        public async Task<IActionResult> DeleteFacture(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            try
            {
                await this.factureService.DeleteFacture(id);
            }
            catch (Exception e)
            {
                return this.StatusCode(500, "Internal server error");
            }

            return NoContent();
        }
    }
}
