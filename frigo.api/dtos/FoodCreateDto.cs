namespace frigo.api.Dtos
{
    public record FoodCreateDto(string Name, int WeightAsGram, DateTimeOffset ExpiresAt);
}
