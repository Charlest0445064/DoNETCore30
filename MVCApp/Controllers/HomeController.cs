using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCApp.Dtos;
using MVCApp.Models;
using MVCApp.Service.DropdownService;
using MVCApp.Service.LocationService;
using System.Diagnostics;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDropdownService _dropdownService;
        private readonly ILogger<HomeController> _logger;
        private readonly KcgContext _kcgContext;
        private readonly ILocationService _locationService;
        public string Name { get; set; }

        public HomeController(ILogger<HomeController> logger, KcgContext kcgContext, IDropdownService dropdownService, ILocationService locationService)
        {
            _logger = logger;
            _kcgContext = kcgContext;
            _dropdownService = dropdownService;
            _locationService = locationService;
        }

        public IActionResult Index()
        {
            var dropdownItems = _dropdownService.GetDropdownItems();
            ViewBag.DropdownItems = dropdownItems;
            ViewBag.Countries = _locationService.GetCountries();
             return View();
          //  return RedirectToAction("Index", "Home", new { area = "Admin" });
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

        public IActionResult MultiSelect()
        {
            var model = new DepartmentViewModel
            {
                AvailableItems = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "選項1" },
                new SelectListItem { Value = "2", Text = "選項2" },
                new SelectListItem { Value = "3", Text = "選項3" }
            },
                SelectedItems = new List<int>() // 預設選中項
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Submit(DepartmentViewModel model)
        {
            // 處理選中的值
            var selectedItems = model.SelectedItems;

            // 其他邏輯...

            return View("Index", model);
        }

        // 這是通過 AJAX 請求來獲取城市列表的 Action
        public JsonResult GetCities(int countryId)
        {
            var cities = _locationService.GetCitiesByCountryId(countryId);
            return Json(cities);
        }

        public IActionResult RelationSelect()
        {
            ViewBag.Countries = _locationService.GetCountries();
            return View();
        }
    }
}
