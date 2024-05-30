using AutoMapper;
using frigo.api.dtos;
using frigo.domain;
using Microsoft.AspNetCore.Mvc;

namespace frigo.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrigoController(Frigo frigo, IMapper mapper) : ControllerBase
    {
        private readonly Frigo _frigo = frigo;
        private readonly IMapper _mapper = mapper;

        [HttpGet("Foods")]
        public async Task<IReadOnlyList<Food>> GetFoods()
        {
            return await Task.FromResult(_frigo.Foods);
        }

        [HttpPost("Foods")]
        public async Task<Food> AddFood(FoodCreateDto foodCreateDto)
        {
            Food food = _mapper.Map<Food>(foodCreateDto);
            _frigo.AddFood(food);
            return await Task.FromResult(food);
        }
    }
}
