namespace frigo.dtos
{
    public record struct FoodCreateDto(string Name, int WeightAsGram, DateTimeOffset ExpiresAt);
}
