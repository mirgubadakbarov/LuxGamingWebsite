using Microsoft.AspNetCore.Mvc;

namespace LugxGamingWebsite.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
