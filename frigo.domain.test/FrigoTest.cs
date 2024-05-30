using Microsoft.Extensions.Time.Testing;

namespace frigo.domain.test
{
    public class FrigoTest
    {
        private readonly Frigo _frigo;

        public FrigoTest()
        {
            FakeTimeProvider fakeTimeProvider = new(new DateTime(2023, 05, 01));
            _frigo = new Frigo(fakeTimeProvider);
            _frigo.AddFood(new Food(Guid.NewGuid(), "Strawberry", 300, new DateTime(2023, 04, 01)));
            _frigo.AddFood(new Food(Guid.NewGuid(), "Apple", 300, new DateTime(2023, 05, 05)));
            _frigo.AddFood(new Food(Guid.NewGuid(), "Annanas", 500, new DateTime(2023, 08, 01)));
        }

        [Fact]
        public void TestExpiresSoon()
        {
            IReadOnlyList<Food> foodExpiresSoon = _frigo.GetFoodsExpiresSoon();
            Assert.Single(foodExpiresSoon);
        }

        [Fact]
        public void TestExpired()
        {
            IReadOnlyList<Food> foodExpiresSoon = _frigo.GetFootExpired();
            Assert.Single(foodExpiresSoon);
        }
    }
}