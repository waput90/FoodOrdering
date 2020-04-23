using System.Threading.Tasks;
using FoodOrdering.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoodOrdering.Web.Controllers
{
    [AllowAnonymous]
    [Route("customer")]
    public class CustomerController: Controller
    {
        private readonly ICustomerService _customerService;
        private readonly ILogger<CustomerController> _logger;
        public CustomerController(
            ICustomerService customerService,
            ILogger<CustomerController> logger)
        {
            _customerService = customerService;
            _logger = logger;
        }

        [Route("get-default"), HttpGet]
        public async Task<JsonResult> GetDefaultCustomer()
        {
            return Json(await _customerService.GetDefaultCustomer());
        }
    }
}