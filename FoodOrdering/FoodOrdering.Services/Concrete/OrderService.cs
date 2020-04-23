using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrdering.Commons.Extensions;
using FoodOrdering.Commons.ViewModel;
using FoodOrdering.Data.Access.Patterns.Factory;
using FoodOrdering.Data.Models;
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

        public async Task<IEnumerable<GetOrderResponseModel>> Get()
        {
            try
            {
                using (var uow = _unitOfWorkFactory.CreateUow())
                {
                    var orders = await uow.GetEntityRepository<Order>().ItemsAsync();
                    var customerOrders = await uow.GetEntityRepository<CustomerOrder>().ItemsWithAsync(null, q => q.Product);

                    if (orders.Any() &&
                        customerOrders.Any())
                    {
                        return orders.OrderByDescending(o => o.OrderDate).Select(q => new GetOrderResponseModel
                        {
                            Id = q.Id,
                            OverallTotal = q.Total,
                            DiscountedTotal = q.DiscountedTotal,
                            OrderItems = customerOrders.Where(o => o.OrderRefId.Equals(q.RefId))
                            .Select(o => new SaveOrderOrderItem
                            {
                                Name = o.Product.Name,
                                Qty = o.Qty,
                                Price = o.Product.Price,
                                Subtotal = o.Total
                            })
                        });
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                _logger.LogTrace(e.StackTrace);
            }
            return default;
        }

        public async Task<bool> SaveOrder(SaveOrderViewModel save)
        {
            try
            {
                if (!save.IsNull())
                {
                    using (var uow = _unitOfWorkFactory.CreateUow())
                    {
                        string orderRefId = Guid.NewGuid().ToString();

                        var orders = save.OrderItems.Select(q => new CustomerOrder
                        {
                            Id = Guid.NewGuid().ToString(),
                            CustomerId = save.CustomerId,
                            ProductId = q.Id,
                            OrderRefId = orderRefId,
                            Qty = q.Qty,
                            Total = q.Subtotal,
                            CouponId = save.DiscountId,
                            DateCreated = DateTime.Now.GetDate()
                        });

                        uow.GetEntityRepository<CustomerOrder>().InsertBulk(orders);

                        uow.GetEntityRepository<Order>().Insert(new Order
                        {
                            Id = Guid.NewGuid().ToString(),
                            CustomerId = save.CustomerId,
                            RefId = orderRefId,
                            Total = save.OrderTotal,
                            DiscountedTotal = save.DiscountedTotal.HasValue ? save.DiscountedTotal.Value : 0.00M,
                            OrderDate = DateTime.Now.GetDate()
                        });

                        await uow.Commit();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                _logger.LogTrace(e.StackTrace);
            }
            return false;
        }
    }
}