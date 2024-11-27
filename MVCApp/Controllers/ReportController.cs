using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class ReportController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly KcgContext _context;

        public ReportController(IHttpClientFactory httpClientFactory, KcgContext context)
        {
            _httpClient = httpClientFactory.CreateClient("SSRSClient");
            _context = context;
        }

        public async Task<IActionResult> DownloadReport()
        {

            string reportUrl = "http://desktop-4rhibjo/Reports/report/Report/Report1?EmployeeId=1&rs:Format=PDF";

            // 向 SSRS 請求報表並以 PDF 格式回傳
            var response = await _httpClient.GetAsync(reportUrl);

            if (response.IsSuccessStatusCode)
            {
                var pdfContent = await response.Content.ReadAsByteArrayAsync();
                return File(pdfContent, "application/pdf", "Report.pdf");
            }
            else
            {
                return Content("無法下載報表。");
            }
        }
       
        public async Task<IActionResult> SendJsonToSSRS()
        {
            // 將模型序列化為 JSON
            var db = _context.News.ToList();
            var jsonContent = JsonConvert.SerializeObject(db);
            var JSON = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            // SSRS 報表伺服器的 URL
            string ssrsUrl = "http://desktop-4rhibjo/Reports/report/Report/ReportEmployee?rs:Format=PDF";

            // 發送 POST 請求到 SSRS
            var response = await _httpClient.PostAsync(ssrsUrl, JSON);

            if (response.IsSuccessStatusCode)
            {
                var pdfContent = await response.Content.ReadAsByteArrayAsync();
                return File(pdfContent, "application/pdf", "Report.pdf");
            }
            else
            {
                return StatusCode((int)response.StatusCode, "Error sending data to SSRS.");
            }
        }
    }
}
