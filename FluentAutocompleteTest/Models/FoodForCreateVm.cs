using System.ComponentModel.DataAnnotations;

namespace FluentAutocompleteTest.Models
{
    public class FoodForCreateVm
    {
        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public IEnumerable<IngredientVm> Ingredients { get; set; } = [];
    }
}
