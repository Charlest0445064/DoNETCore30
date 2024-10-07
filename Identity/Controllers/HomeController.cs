using Identity.Models;
using Identity.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Identity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly KcgContext _context;
      
        public HomeController(ILogger<HomeController> logger, KcgContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            CombineViewModel combineViewModel = new CombineViewModel();
            combineViewModel.NewsList = _context.News.ToList();
            combineViewModel.EmployeeList = _context.Employee.ToList();
          //  var q = _context.News.ToList();
            return View(combineViewModel);
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
