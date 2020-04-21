using System.Collections.Generic;

namespace FoodOrdering.Commons.ViewModel
{
    public class GetMenuWithProductViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<ProductItem> Products { get; set; }
    }

    public class ProductItem 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}