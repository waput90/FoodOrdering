using System.Threading.Tasks;

namespace FoodOrdering.Services.Abstract
{
    public interface ICustomerService
    {
        Task<string> GetDefaultCustomer();
    }
}