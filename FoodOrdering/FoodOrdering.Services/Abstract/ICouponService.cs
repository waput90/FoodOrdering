using System.Threading.Tasks;
using FoodOrdering.Commons.ViewModel;

namespace FoodOrdering.Services.Abstract
{
    public interface ICouponService
    {
        Task<GetCouponResponseModel> GetCouponByName(string name);
        Task<bool> UseCoupon(string couponId);
    }
}