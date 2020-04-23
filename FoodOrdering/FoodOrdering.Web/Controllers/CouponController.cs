using System.Threading.Tasks;
using FoodOrdering.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoodOrdering.Web.Controllers
{
    [AllowAnonymous]
    [Route("coupon")]
    public class CouponController : Controller
    {
        private readonly ICouponService _couponService;
        private readonly ILogger<CouponController> _logger;
        public CouponController(
            ICouponService couponService,
            ILogger<CouponController> logger)
        {
            _couponService = couponService;
            _logger = logger;
        }

        [Route("get"), HttpGet]
        public async Task<JsonResult> GetDefaultCustomer(string code)
        {
            if (!string.IsNullOrWhiteSpace(code))
                return Json(await _couponService.GetCouponByName(code));
            return Json(new { msg = "Coupon code must not empty" });
        }
    }
}