using Microsoft.AspNetCore.Mvc;

namespace Phonia.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
