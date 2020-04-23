using System.Collections.Generic;

namespace FoodOrdering.Commons.ViewModel
{
    public class SaveOrderViewModel
    {
        public string CustomerId { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
        public string DiscountId { get; set; }
        public decimal OrderTotal { get; set; }
        public decimal? DiscountedTotal { get; set; }
    }

    public class OrderItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal Subtotal { get; set; }
    }
}