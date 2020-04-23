using System.Threading.Tasks;
using FoodOrdering.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoodOrdering.Web.Controllers
{
    [AllowAnonymous]
    [Route("menu")]
    public class MenuController: Controller
    {
        private readonly IMenuService _menuService;
        private readonly ILogger<MenuController> _logger;
        public MenuController(
            IMenuService menuService,
            ILogger<MenuController> logger)
        {
            _menuService = menuService;
            _logger = logger;
        }

        [Route("get"), HttpGet]
        public async Task<JsonResult> GetMenu()
        {
            return Json(await _menuService.Get());
        }
    }
}