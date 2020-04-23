using System;
using System.Threading.Tasks;
using FoodOrdering.Commons.ViewModel;
using FoodOrdering.Data.Access.Patterns.Factory;
using FoodOrdering.Services.Abstract;
using Microsoft.Extensions.Logging;

namespace FoodOrdering.Services.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly ILogger<OrderService> _logger;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        public OrderService(
            IUnitOfWorkFactory unitOfWorkFactory,
            ILogger<OrderService> logger)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            _logger = logger;
        }

        public Task<GetOrderResponseModel> Get()
        {
            throw new NotImplementedException();
        }

        public Task<string> SaveOrder(SaveOrderViewModel save)
        {
            throw new NotImplementedException();
        }
    }
}