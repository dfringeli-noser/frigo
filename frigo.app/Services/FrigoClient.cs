using frigo.domain;

namespace frigo.app.Services
{
    public class FrigoClient(HttpClient http)
    {
        public async Task<Food[]> GetFrigoFoods()
        {
            return await http.GetFromJsonAsync<Food[]>("Frigo/Foods") ?? [];
        }
    }
}
