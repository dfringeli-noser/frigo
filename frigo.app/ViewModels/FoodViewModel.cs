namespace frigo.app.ViewModels
{
    public record struct FoodViewModel(Guid Id, string Name, int WeightAsGram, TimeSpan ExpireIn)
    {
        public readonly string ExpireInDaysText => $"{(int)Math.Floor(ExpireIn.TotalDays)} days";

        public readonly string WeightAsGramText => $"{WeightAsGram}g";
    }
}
