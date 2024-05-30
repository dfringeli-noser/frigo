using System.ComponentModel.DataAnnotations;

namespace frigo.app.ViewModels
{
    public class FoodCreateViewModel : IValidatableObject
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(10, double.MaxValue)]
        public int WeightAsGram { get; set; } = 0;

        [Required]
        [DataType(DataType.Date)]
        public DateTimeOffset ExpiresAt { get; set; } = DateTimeOffset.Now;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ExpiresAt <= DateTimeOffset.Now)
            {
                yield return new ValidationResult("Expires at must be in the future.");
            }
        }
    }
}
