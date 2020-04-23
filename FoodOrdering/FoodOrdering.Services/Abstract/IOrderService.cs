using System.Threading.Tasks;
using FoodOrdering.Commons.ViewModel;

namespace FoodOrdering.Services.Abstract
{
    public interface IOrderService
    {
        Task<GetOrderResponseModel> Get(); // get orders
        Task<string> SaveOrder(SaveOrderViewModel save);
    }
}