using Microsoft.AspNetCore.Mvc;

namespace FoodOrdering.Web.Controllers
{
    public class RedirController: Controller
    {
        public IActionResult Index()
        {
            return Redirect("/home");
        }
    }
}