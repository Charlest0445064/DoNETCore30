using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Areas.Department.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
