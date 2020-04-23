using System.Threading.Tasks;
using FoodOrdering.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoodOrdering.Web.Controllers
{
    [AllowAnonymous]
    [Route("order")]
    public class OrderController: Controller
    {
        private readonly IOrderService _orderService;
        private readonly ILogger<OrderController> _logger;
        public OrderController(
            IOrderService orderService,
            ILogger<OrderController> logger)
        {
            _orderService = orderService;
            _logger = logger;
        }

        [Route("get"), HttpGet]
        public async Task<JsonResult> GetMenu()
        {
            return Json(await _orderService.Get());
        }
    }
}