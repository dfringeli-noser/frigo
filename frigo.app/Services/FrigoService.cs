using AutoMapper;
using frigo.app.ViewModels;
using frigo.dtos;

namespace frigo.app.Services
{
    public class FrigoService(FrigoClient frigoClient, IMapper mapper)
    {
        public async Task<FoodViewModel[]> GetFrigoFoodsAsync()
        {
            var foods = await frigoClient.GetFrigoFoodsAsync();
            return mapper.Map<FoodViewModel[]>(foods);
        }

        public async Task<FoodViewModel> AddNewFoodAsync(FoodCreateViewModel foodCreate)
        {
            var foodCreateDto = mapper.Map<FoodCreateDto>(foodCreate);
            var food = await frigoClient.CreateFrigoFoodAsync(foodCreateDto);
            return mapper.Map<FoodViewModel>(food);
        }
    }
}
