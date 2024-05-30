namespace frigo.domain
{
    public record Food(Guid Id, string Name, int WeightAsGram, DateTimeOffset ExpiresAt);
}
