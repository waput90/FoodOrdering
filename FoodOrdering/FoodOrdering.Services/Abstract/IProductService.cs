using System.Collections.Generic;
using System.Threading.Tasks;
using FoodOrdering.Commons.ViewModel;

namespace FoodOrdering.Services.Abstract
{
    public interface IProductService
    {
        Task<IEnumerable<GetProductResponseModel>> Get();
        Task<bool> Add(AddProductRequestModel model);
    }
}