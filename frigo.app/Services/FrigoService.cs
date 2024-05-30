using AutoMapper;
using frigo.app.ViewModels;

namespace frigo.app.Services
{
    public class FrigoService(FrigoClient frigoClient, IMapper mapper)
    {
        public async Task<FoodViewModel[]> GetFrigoFoodsAsync()
        {
            var foods = await frigoClient.GetFrigoFoodsAsync();
            return mapper.Map<FoodViewModel[]>(foods);
        }
    }
}
