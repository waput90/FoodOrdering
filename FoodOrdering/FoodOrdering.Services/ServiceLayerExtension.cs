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
            service.TryAddTransient<IProductService, ProductService>();
            service.TryAddTransient<IMenuService, MenuService>();
            return service;
        }
    }
}
