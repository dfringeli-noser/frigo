using frigo.domain;
using frigo.dtos;

namespace frigo.app.Services
{
    public class FrigoClient(HttpClient http)
    {
        public async Task<Food[]> GetFrigoFoodsAsync()
        {
            return await http.GetFromJsonAsync<Food[]>("Frigo/Foods") ?? [];
        }

        public async Task<Food> CreateFrigoFoodAsync(FoodCreateDto foodCreate)
        {
            var response = await http.PostAsJsonAsync("Frigo/Foods", foodCreate);
            return await response.Content.ReadFromJsonAsync<Food>();
        }
    }
}
