namespace frigo.domain
{
    public class Frigo(TimeProvider timeProvider)
    {
        private readonly TimeSpan _expiresSoonThreshold = TimeSpan.FromDays(7);
        private readonly IList<Food> _foods = [];
        private readonly TimeProvider _timeProvider = timeProvider;

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
            DateTimeOffset now = _timeProvider.GetLocalNow();
            DateTimeOffset expiresSoon = now.Add(_expiresSoonThreshold);
            return _foods.Where(f => f.ExpiresAt > now && f.ExpiresAt < expiresSoon).ToArray();
        }

        public IReadOnlyList<Food> GetFootExpired()
        {
            DateTimeOffset now = _timeProvider.GetLocalNow();
            return _foods.Where(f => f.ExpiresAt < now).ToArray();
        }
    }
}
