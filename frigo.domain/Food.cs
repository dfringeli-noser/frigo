namespace frigo.domain
{
    public record struct Food(Guid Id, string Name, int WeightAsGram, DateTimeOffset ExpiresAt);
}
