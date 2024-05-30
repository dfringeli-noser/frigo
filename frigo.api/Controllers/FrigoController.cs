using AutoMapper;
using frigo.domain;
using frigo.dtos;
using Microsoft.AspNetCore.Mvc;

namespace frigo.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrigoController(Frigo frigo, IMapper mapper) : ControllerBase
    {
        [HttpGet("Foods")]
        public async Task<IReadOnlyList<Food>> GetFoods()
        {
            return await Task.FromResult(frigo.Foods);
        }

        [HttpPost("Foods")]
        public async Task<Food> AddFood(FoodCreateDto foodCreateDto)
        {
            Food food = mapper.Map<Food>(foodCreateDto);
            frigo.AddFood(food);
            return await Task.FromResult(food);
        }
    }
}
