using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class DemoController : Controller
    {
        private readonly KcgContext _context;
        public DemoController(KcgContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var q = _context.TOPMenu.FirstOrDefault();
           return View(q);
        }
    }
}
