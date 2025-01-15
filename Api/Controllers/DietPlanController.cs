using AutoMapper;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietPlanController : BaseController
    {
        private readonly IDietplanService _dietplanService;
        public DietPlanController(UserManager<User> userManager, IMapper mapper, IDietplanService dietplanService) : base(userManager, mapper)
        {
            _dietplanService = dietplanService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DietPlan>>> GetDietplans()
        {
            return Ok(await _dietplanService.GetAllAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Meal>> GetDietplan(int id)
        {
            var dietPlan = await _dietplanService.GetAsync(id);
            if (dietPlan == null)
                return NotFound();

            return Ok(dietPlan);
        }

        [HttpGet("GetDietplansByClientId")]
        public async Task<ActionResult<IEnumerable<DietPlan>>> GetDietplansByClientId(int clientId)
        {
            return Ok(await _dietplanService.GetAllByClientIdAsync(clientId));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, DietPlan dietPlan)
        {
            dietPlan.Meals[0].DietPlanId = id;
            if (id != dietPlan.Id)
                return BadRequest();

            await _dietplanService.UpdateAsync(dietPlan);
            return Ok(dietPlan);
        }
        [HttpGet("GetDietplansCount")]
        public async Task<int> GetClientCountAsync()
        {
            return await _dietplanService.CountAsync();
        }
    }
}
