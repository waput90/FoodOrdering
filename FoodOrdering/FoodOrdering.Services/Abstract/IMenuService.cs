using System.Collections.Generic;
using System.Threading.Tasks;
using FoodOrdering.Commons.ViewModel;

namespace FoodOrdering.Services.Abstract
{
    public interface IMenuService
    {
        Task<IEnumerable<GetMenuWithProductViewModel>> Get();
        Task<bool> Add(AddMenuRequestModel model);
    }
}