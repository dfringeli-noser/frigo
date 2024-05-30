namespace frigo.api.dtos
{
    public record FoodCreateDto(string Name, int WeightAsGram, DateTimeOffset ExpiresAt);
}
