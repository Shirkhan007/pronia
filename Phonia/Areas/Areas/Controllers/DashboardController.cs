using Microsoft.AspNetCore.Mvc;

namespace Phonia.Areas.Areas.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Areas")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
