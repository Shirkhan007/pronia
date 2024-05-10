using Microsoft.AspNetCore.Mvc;

namespace Phonia.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
