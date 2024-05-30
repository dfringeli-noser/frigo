using Microsoft.Extensions.Time.Testing;

namespace frigo.domain.test
{
    public class FrigoTest
    {
        private readonly FakeTimeProvider _fakeTimeProvider = new(new DateTime(2023, 05, 01));
        private readonly Frigo _frigo;

        public FrigoTest()
        {
            _frigo = new Frigo(_fakeTimeProvider);
            _frigo.AddFood(new Food(Guid.NewGuid(), "Strawberry", 300, new DateTime(2023, 04, 01)));
            _frigo.AddFood(new Food(Guid.NewGuid(), "Apple", 300, new DateTime(2023, 05, 05)));
            _frigo.AddFood(new Food(Guid.NewGuid(), "Annanas", 500, new DateTime(2023, 08, 01)));
        }

        [Fact]
        public void TestExpiresSoon()
        {
            IReadOnlyList<Food> foodExpiresSoon = _frigo.GetFoodsExpiresSoon();
            Assert.Single(foodExpiresSoon);
            _fakeTimeProvider.Advance(new TimeSpan(5, 0, 0, 0, 0));
            foodExpiresSoon = _frigo.GetFoodsExpiresSoon();
            Assert.Empty(foodExpiresSoon);
        }

        [Fact]
        public void TestExpired()
        {
            IReadOnlyList<Food> foodExpired = _frigo.GetFootExpired();
            Assert.Single(foodExpired);
            _fakeTimeProvider.Advance(new TimeSpan(5, 0, 0, 0, 0));
            foodExpired = _frigo.GetFootExpired();
            Assert.Equal(2, foodExpired.Count);
        }
    }
}