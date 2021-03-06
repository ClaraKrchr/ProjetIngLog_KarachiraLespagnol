using System;
using System.Collections.Generic;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Projet.Business.DTO;
using Projet.Business.Services;
using System.Web.Http.Cors;

namespace Projet.Controller
{
    [EnableCors(origins: "*", headers: "*", methods: "get, post, put, delete")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService clientService;

        public ClientsController(IClientService service)
        {
            this.clientService = service;
        }

        //POST : api/Clients
        [HttpPost("CreateClient")]
        public async Task<ActionResult<ClientDto>> Create(ClientDto dto)
        {
            try
            {
                return await this.clientService.AddClient(dto);
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
        [HttpPut("{id}/UpdateClient")]
        public async Task<ActionResult<ClientDto>> UpdateClient(int id, ClientDto dto)
        {
            if (id != dto.Id)
            {
                return this.BadRequest();
            }

            try
            {
                return await this.clientService.UpdateClient(dto);
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
        [HttpGet("{id}/Client")]
        public async Task<ActionResult<ClientDto>> GetClient(int id)
        {
            if (id <= default(int))
            {
                return NotFound();
            }

            try
            {
                return await this.clientService.GetClient(id);
            }

            catch (Exception e)
            {
                return this.StatusCode(500, "Internal Server error");
            }
        }

        // [EnableCors("MyallowSpecificOrigins")]
        [HttpGet("all/Client")]
        public ActionResult<List<ClientDto>> GetAllClients()
        {
            try
            {
                return this.clientService.GetAllClients();
            }

            catch (Exception e)
            {
                return this.StatusCode(500, "Internal Server error");
            }
        }

        //DELETE : api/Shop/5
        [HttpDelete("{id}/DeleteClient")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            try
            {
                await this.clientService.DeleteClient(id);
            }
            catch (Exception e)
            {
                return this.StatusCode(500, "Internal server error");
            }

            return NoContent();
        }
    }
}
