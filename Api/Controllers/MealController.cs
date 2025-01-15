using AutoMapper;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;
using System.Net;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealController : BaseController
    {
        private readonly IMealService _mealService;
        public MealController(UserManager<User> userManager, IMapper mapper, IMealService mealService) : base(userManager, mapper)
        {
            _mealService = mealService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Meal>>> GetList()
        {
            return Ok(await _mealService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Meal>> GetMeal(int id)
        {
            var client = await _mealService.GetAsync(id);
            if (client == null)
                return NotFound();

            return Ok(client);
        }

        [HttpGet("GetMealsByDietplanId")]
        public async Task<ActionResult<IEnumerable<Meal>>> GetMealsByDietplanId(int dietplanId)
        {
            return Ok(await _mealService.GetAllByDietplanIdAsync(dietplanId));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Meal meal)
        {

            if (id! > 0)
                return BadRequest();

            await _mealService.UpdateAsync(meal);
            return Ok(meal);
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync(Meal meal)
        {
            try
            {
            await _mealService.AddAsync(meal);
                return Ok(meal);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("GetMealsCount")]
        public async Task<int> GetMealsCountAsync()
        {
            return await _mealService.CountAsync();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                await _mealService.HardDeleteAsync(id);
                return NoContent();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
