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
    public class MenuService : IMenuService
    {
        private readonly ILogger<MenuService> _logger;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        public MenuService(
            IUnitOfWorkFactory unitOfWorkFactory,
            ILogger<MenuService> logger)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            _logger = logger;
        }

        public async Task<bool> Add(AddMenuRequestModel model)
        {
            try
            {
                if (!model.IsNull())
                {
                    using (var uow = _unitOfWorkFactory.CreateUow())
                    {
                        uow.GetEntityRepository<Menu>().Insert(new Menu
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = model.Name,
                            Description = model.Description,
                            DateCreated = DateTime.Now.GetDate(),

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

        public async Task<IEnumerable<GetMenuWithProductViewModel>> Get()
        {
            try
            {
                using (var uow = _unitOfWorkFactory.CreateUow())
                {
                    var menuItem = await uow.GetEntityRepository<Menu>().ItemsWithAsync(null);
                    var products = await uow.GetEntityRepository<Product>().ItemsAsync(null);

                    if (menuItem != null &&
                        menuItem.Any())
                        return menuItem.Select(q => new GetMenuWithProductViewModel
                        {
                            Id = q.Id,
                            Name = q.Name,
                            Description = q.Name,
                            Products = products.Where(w => w.MenuId.Equals(q.Id))
                            .Select(p => new ProductItem
                            {
                                Id = p.Id,
                                Name = p.Name,
                                Price = p.Price,
                                Description = p.Description
                            })
                        });
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                _logger.LogTrace(e.StackTrace);
            }
            return default;
        }
    }
}