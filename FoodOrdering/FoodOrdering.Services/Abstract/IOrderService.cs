using System.Collections.Generic;
using System.Threading.Tasks;
using FoodOrdering.Commons.ViewModel;

namespace FoodOrdering.Services.Abstract
{
    public interface IOrderService
    {
        Task<IEnumerable<GetOrderResponseModel>> Get(); // get orders
        Task<bool> SaveOrder(SaveOrderViewModel save);
    }
}