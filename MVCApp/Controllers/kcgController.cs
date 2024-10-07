using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class kcgController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
