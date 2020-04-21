using System;
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
    public class ProductService : IProductService
    {
        private readonly ILogger<ProductService> _logger;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        public ProductService(
            IUnitOfWorkFactory unitOfWorkFactory,
            ILogger<ProductService> logger)
        {
            _logger = logger;
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task<bool> Add(AddProductRequestModel model)
        {
            try
            {
                if (!model.IsNull())
                {
                    using (var uow = _unitOfWorkFactory.CreateUow())
                    {
                        uow.GetEntityRepository<Product>().Insert(new Product
                        {
                            Id = Guid.NewGuid().ToString(),
                            MenuId = model.MenuId,
                            Name = model.Name,
                            Price = model.Price,
                            Description = model.Description,
                            DateCreated = DateTime.Now.GetDate()
                        });

                        await uow.Commit();
                        return true;
                    }
                }
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
                _logger.LogTrace(e.StackTrace);
            }
            return false;
        }

        public async Task<IEnumerable<GetProductResponseModel>> Get()
        {
            try
            {
                using (var uow = _unitOfWorkFactory.CreateUow())
                {
                    var products = await uow.GetEntityRepository<Product>().ItemsAsync();

                    if (products != null &&
                        products.Any())
                        return products.Select(q => new GetProductResponseModel
                        {
                            Id = q.Id,
                            Name = q.Name,
                            DateCreated = q.DateCreated,
                            Description = q.Description,
                            Price = q.Price
                        });
                }
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
                _logger.LogTrace(e.StackTrace);
            }
            return default;
        }
    }
}