using Microsoft.Extensions.DependencyInjection;

namespace FoodOrdering.Services
{
    public static class ServiceLayerExtension
    {
        public static IServiceCollection RegisterService(this IServiceCollection service)
        {

            return service;
        }
    }
}
