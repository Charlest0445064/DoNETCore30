using Microsoft.AspNetCore.Mvc;
using MVCApp.Service.DropdownService;
using MVCApp.Service.LocationService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MVCApp.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IDropdownService _dropdownService;
        private readonly ILocationService _locationService;

        public HomeController(IDropdownService dropdownService, ILocationService locationService)
        {
            _dropdownService = dropdownService;
            _locationService = locationService;
        }

        public IActionResult Index()
        {
            var dropdownItems = _dropdownService.GetDropdownItems();
            ViewBag.DropdownItems = dropdownItems;
            ViewBag.Countries = _locationService.GetCountries();
            return View();
        }

        public JsonResult GetCities(int countryId)
        {
            var cities = _locationService.GetCitiesByCountryId(countryId);
            return Json(cities);
        }

        [HttpPost]
        public IActionResult HandleForm(string action)
        {
            if (action == "Save")
            {
                // 调用保存操作
                return RedirectToAction("SaveAction");
            }
            else if (action == "Cancel")
            {
                // 调用取消操作
                return RedirectToAction("CancelAction");
            }

            // 默认返回某个视图或action
            return View();
        }

        public IActionResult SaveAction()
        {
            // 保存的逻辑
            return View();
        }

        public IActionResult CancelAction()
        {
            // 取消的逻辑
            return View();
        }

    }
}
