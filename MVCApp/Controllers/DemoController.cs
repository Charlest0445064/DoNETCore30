﻿using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using System.Collections.Generic;

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
           
           return View();
        }
        [HttpPost]
        public IActionResult Index(Employee data)
        {

            return View();
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

        public  IActionResult PostArray()
        {

            return Content("123");
        }

        // Action Method
        public void MyAction(List<int> data)
        {
            // do stuff here
        }

        public IActionResult Del()
        {
            //EXEC sp_configure 'show advanced options', 1;
            //RECONFIGURE;
            //EXEC sp_configure 'xp_cmdshell', 1;
            //RECONFIGURE;

            //DECLARE @Command NVARCHAR(4000);
            //SET @Command = 'DEL /Q "C:\temp\example.txt"'; -- / Q 表示安靜模式，不提示
            //EXEC xp_cmdshell @Command;
            return View();
        }
    }
}
