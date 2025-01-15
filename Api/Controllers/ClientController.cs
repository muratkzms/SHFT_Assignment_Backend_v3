using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;
using Shared.Utilities.Results.Abstract;
using Shared.Utilities.Results.ComplexTypes;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : BaseController
    {
        private readonly IClientService _clientService;
        public ClientController(UserManager<User> userManager, IMapper mapper, IClientService clientService) : base(userManager, mapper)
        {
            _clientService = clientService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetListAsync()
        {
            return Ok(await _clientService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetClient(int id)
        {
            var client = await _clientService.GetAsync(id);
            if (client == null)
                return NotFound();

            return Ok(client);
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync(Client client)
        {
            await _clientService.AddAsync(client);
            return CreatedAtAction(nameof(GetClient), new { id = client.Id }, client);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, Client client)
        {
            client.DietPlans[0].ClientId = id;
            if (id != client.Id)
                return BadRequest();

            await _clientService.UpdateAsync(client);
            return Ok(client);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _clientService.HardDeleteAsync(id);
            return NoContent();
        }

        [HttpGet("GetClientsCount")]
        public async Task<int> GetClientCountAsync()
        {
            return await _clientService.CountAsync();
        }
    }
}

