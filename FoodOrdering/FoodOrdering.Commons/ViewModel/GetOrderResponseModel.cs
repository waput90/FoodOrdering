using System.Collections.Generic;

namespace FoodOrdering.Commons.ViewModel
{
    public class GetOrderResponseModel
    {
        public string Id { get; set; }
        public IEnumerable<SaveOrderOrderItem> OrderItems { get; set; }
        public decimal OverallTotal { get; set; }
        public decimal? DiscountedTotal { get; set; }
    }

    public class SaveOrderOrderItem
    {
        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal { get; set; }
    }
}