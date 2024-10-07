using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Components
{
    public class abcViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
