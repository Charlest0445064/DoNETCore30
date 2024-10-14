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

        public IActionResult Download()
        {          
            return View();
        }

        public IActionResult DownloadFile(string fileName)
        {
            // 定義檔案的路徑
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", fileName);

            // 檢查檔案是否存在
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("檔案不存在");
            }

            // 讀取檔案的位元組
            var fileBytes = System.IO.File.ReadAllBytes(filePath);

            // 傳送檔案到客戶端
            return File(fileBytes, "application/octet-stream", fileName);
        }
    }
}
