using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace RazorApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            
        }

        public string NowTime { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
            NowTime = DateTime.Now.ToString("HH/mm/ss");
            Message = "Hello World This is a razor Page";
            _logger.LogInformation("About page visited at {DT}",
            DateTime.UtcNow.ToLongTimeString());
        }
    }
}
