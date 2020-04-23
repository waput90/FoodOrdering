using FoodOrdering.Services.Abstract;
using FoodOrdering.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace FoodOrdering.Services
{
    public static class ServiceLayerExtension
    {
        public static IServiceCollection RegisterService(this IServiceCollection service)
        {
            service.TryAddTransient<ICouponService, CouponService>();
            service.TryAddTransient<ICustomerService, CustomerService>();
            service.TryAddTransient<ICouponService, CouponService>();
            service.TryAddTransient<IProductService, ProductService>();
            service.TryAddTransient<IOrderService, OrderService>();
            service.TryAddTransient<IMenuService, MenuService>();
            return service;
        }
    }
}
