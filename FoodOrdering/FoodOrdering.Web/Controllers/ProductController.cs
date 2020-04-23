using System.Threading.Tasks;
using FoodOrdering.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoodOrdering.Web.Controllers
{
    [AllowAnonymous]
    [Route("product")]
    public class ProductController: Controller
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;
        public ProductController(
            IProductService productService,
            ILogger<ProductController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        [Route("get"), HttpGet]
        public async Task<JsonResult> GetMenu()
        {
            return Json(await _productService.Get());
        }
    }
}