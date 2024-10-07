using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using System.Diagnostics;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly KcgContext _kcgContext;
        public string Name { get; set; }

        public HomeController(ILogger<HomeController> logger, KcgContext kcgContext)
        {
            _logger = logger;
            _kcgContext = kcgContext;
        }

        public IActionResult Index()
        {
            Console.WriteLine("action °õ¦æ¤¤");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
