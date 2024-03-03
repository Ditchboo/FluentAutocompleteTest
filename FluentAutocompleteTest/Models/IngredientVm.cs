namespace FluentAutocompleteTest.Models
{
    public class IngredientVm
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public IngredientTypeVm? Type { get; set; }
    }
}
