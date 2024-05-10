using Microsoft.AspNetCore.Mvc;

namespace Phonia.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
