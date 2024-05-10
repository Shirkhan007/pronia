using Microsoft.AspNetCore.Mvc;
using Phonia.DAL;

namespace Phonia.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int? id)
        {
            return View();
        }
    }
}