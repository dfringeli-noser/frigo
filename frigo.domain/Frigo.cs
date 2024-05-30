namespace frigo.domain
{
    public class Frigo
    {
        private readonly TimeSpan _expiresSoonThreshold = TimeSpan.FromDays(7);

        private readonly IList<Food> _foods = new List<Food>();

        public IReadOnlyList<Food> Foods => _foods.AsReadOnly();

        public void AddFood(Food food)
        {
            _foods.Add(food);
        }

        public void RemoveFood(Food food)
        {
            _foods.Remove(food);
        }

        public IReadOnlyList<Food> GetFoodsExpiresSoon()
        {
            DateTime expiresSoon = DateTime.Now.Add(_expiresSoonThreshold);
            return _foods.Where(f => f.ExpiresAt > DateTime.Now && f.ExpiresAt < expiresSoon).ToArray();
        }

        public IReadOnlyList<Food> GetFootExpired()
        {
            return _foods.Where(f => f.ExpiresAt < DateTime.Now).ToArray();
        }
    }
}
