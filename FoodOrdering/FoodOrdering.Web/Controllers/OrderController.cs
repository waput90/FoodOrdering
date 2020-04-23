using System;
using System.Threading.Tasks;
using FoodOrdering.Commons.Extensions;
using FoodOrdering.Commons.ViewModel;
using FoodOrdering.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoodOrdering.Web.Controllers
{
    [AllowAnonymous]
    [Route("order")]
    public class OrderController : Controller
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

        [ValidateAntiForgeryToken]
        [Route("save"), HttpPost]
        public async Task<JsonResult> SaveOrder(SaveOrderViewModel save)
        {
            try
            {
                if (!save.IsNull())
                    return Json(new { succeeded = await _orderService.SaveOrder(save) });
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                _logger.LogTrace(e.StackTrace);
            }
            return Json(new { succeeded = false });
        }
    }
}