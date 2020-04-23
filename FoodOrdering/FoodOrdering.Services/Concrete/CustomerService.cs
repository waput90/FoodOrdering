using System;
using System.Linq;
using System.Threading.Tasks;
using FoodOrdering.Commons.Extensions;
using FoodOrdering.Data.Access.Patterns.Factory;
using FoodOrdering.Data.Models;
using FoodOrdering.Services.Abstract;
using Microsoft.Extensions.Logging;

namespace FoodOrdering.Services.Concrete
{
    public class CustomerService: ICustomerService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        private readonly ILogger<CustomerService> _logger;
        public CustomerService(
            IUnitOfWorkFactory unitOfWorkFactory,
            ILogger<CustomerService> logger)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            _logger = logger;
        }

        public async Task<string> GetDefaultCustomer()
        {
            try
            {
                using (var uow = _unitOfWorkFactory.CreateUow())
                {
                    var customer = (await uow.GetEntityRepository<Customer>()
                                            .ItemsAsync())
                                            .FirstOrDefault();

                    if (!customer.IsNull())
                        return customer.Id;
                }
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
                _logger.LogTrace(e.StackTrace);
            }
            return string.Empty;
        }
    }
}