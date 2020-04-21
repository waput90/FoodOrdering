namespace FoodOrdering.Commons.ViewModel
{
    public class AddProductRequestModel
    {
        public string MenuId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}