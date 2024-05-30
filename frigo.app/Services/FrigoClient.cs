using frigo.domain;

namespace frigo.app.Services
{
    public class FrigoClient(HttpClient http)
    {
        public async Task<Food[]> GetFrigoFoodsAsync()
        {
            return await http.GetFromJsonAsync<Food[]>("Frigo/Foods") ?? [];
        }
    }
}
