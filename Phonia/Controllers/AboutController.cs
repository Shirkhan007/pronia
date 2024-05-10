using Microsoft.AspNetCore.Mvc;

namespace Phonia.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
