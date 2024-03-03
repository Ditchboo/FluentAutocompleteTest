using System.ComponentModel.DataAnnotations;

namespace FluentAutocompleteTest.Models
{
    public class IngredientForCreateVm
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public IngredientTypeVm? Type { get; set; }

        public IEnumerable<IngredientTypeVm> IngredientTypePicker { get; set; } = Array.Empty<IngredientTypeVm>();
    }
}
