namespace frigo.app.ViewModels
{
    public record struct FoodViewModel(Guid Id, string Name, int WeightAsGram, TimeSpan ExpireIn, DateTimeOffset ExpiresAt)
    {
        public readonly string ExpireInDaysText => $"{(int)Math.Floor(ExpireIn.TotalDays)} days";

        public readonly string WeightAsGramText => $"{WeightAsGram}g";

        public readonly string ExpiresAtText => ExpiresAt.ToString();
    }
}
