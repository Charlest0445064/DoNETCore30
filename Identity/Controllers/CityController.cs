using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Identity.Models;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    public class CityController : Controller 
    {
        private readonly KcgContext db;

        public CityController(KcgContext _db)
        {
            db = _db;
        }

        // 顯示表單的主頁面
        public ActionResult Index()
        {
            ViewBag.Cities = new SelectList(db.City, "CityId", "Name");
            return View();
        }

        // 當用戶選擇 City 時返回相應的 Districts
        public JsonResult GetDistricts(int cityId)
        {
            var districts = db.District
                              .Where(d => d.CityId == cityId)
                              .Select(d => new { d.DistrictId, d.Name })
                              .ToList();
            return Json(districts);
        }

        // 當用戶選擇 District 時返回相應的 Villages
        public JsonResult GetVillages(int districtId)
        {
            var villages = db.Village
                             .Where(v => v.DistrictId == districtId)
                             .Select(v => new { v.VillageId, v.Name })
                             .ToList();
            return Json(villages);
        }
    }
}
