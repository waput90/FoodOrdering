using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodOrdering.Web.Models;
using Microsoft.Extensions.Logging;
using FoodOrdering.Services.Abstract;
using FoodOrdering.Commons.ViewModel;

namespace FoodOrdering.Web.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMenuService _menuService;
        private readonly IProductService _productService;
        public HomeController(
             IProductService productService,
            IMenuService menuService,
            ILogger<HomeController> logger)
        {
            _productService = productService;
            _menuService = menuService;
            _logger = logger;
        }

        [Route("insert"), HttpPost]
        public async Task<JsonResult> Add([FromBody] AddProductRequestModel model)
        {
            return Json(await _productService.Add(model));
        }

        [Route("get-menu"), HttpGet]
        public async Task<JsonResult> GetMenu()
        {
            return Json(await _menuService.Get());
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("404")]
        public IActionResult FourOFour() => View();

        [Route("error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
