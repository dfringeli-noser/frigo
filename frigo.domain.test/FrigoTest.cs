namespace frigo.domain.test
{
    public class FrigoTest
    {
        private readonly Frigo _frigo;

        public FrigoTest()
        {
            _frigo = new Frigo();
            _frigo.AddFood(new Food(Guid.NewGuid(), "Strawberry", 300, new DateTime(2024, 05, 01)));
            _frigo.AddFood(new Food(Guid.NewGuid(), "Apple", 300, new DateTime(2024, 06, 01)));
            _frigo.AddFood(new Food(Guid.NewGuid(), "Annanas", 500, new DateTime(2024, 08, 01)));
        }

        [Fact]
        public void TestExpiresSoon()
        {
            IReadOnlyList<Food> foodExpiresSoon = _frigo.GetFoodsExpiresSoon();
            Assert.Equal(1, foodExpiresSoon.Count);
        }

        [Fact]
        public void TestExpired()
        {
            IReadOnlyList<Food> foodExpiresSoon = _frigo.GetFootExpired();
            Assert.Equal(1, foodExpiresSoon.Count);
        }
    }
}