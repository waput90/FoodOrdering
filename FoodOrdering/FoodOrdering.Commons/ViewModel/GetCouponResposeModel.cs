namespace FoodOrdering.Commons.ViewModel
{
    public class GetCouponResponseModel
    {
        public string Id { get; set; }
        public bool IsAvail { get; set; }
        public decimal Discount { get; set; }
        public bool IsValid { get; set; }
    }
}