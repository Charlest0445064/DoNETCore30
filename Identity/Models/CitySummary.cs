using Microsoft.AspNetCore.Mvc;

namespace Identity.Models
{
    public class CitySummary : ViewComponent
    {
        private readonly KcgContext data;
        public CitySummary(KcgContext context)
        {
            data = context;
        }
        public string Invoke()
        {
            return $"{data.City.Count()} cities, "
            + " people";
        }
    }
}
