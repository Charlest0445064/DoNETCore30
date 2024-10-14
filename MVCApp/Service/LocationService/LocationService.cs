using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCApp.Service.LocationService
{
    public class LocationService : ILocationService
    {
        // 模擬的數據源，可以從數據庫中獲取實際數據
        private readonly Dictionary<int, List<string>> citiesByCountry = new Dictionary<int, List<string>>
    {
        { 1, new List<string> { "New York", "Los Angeles", "Chicago" } },
        { 2, new List<string> { "Tokyo", "Osaka", "Kyoto" } }
    };

        public IEnumerable<SelectListItem> GetCountries()
        {
            return new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "USA" },
            new SelectListItem { Value = "2", Text = "Japan" }
        };
        }

        public IEnumerable<SelectListItem> GetCitiesByCountryId(int countryId)
        {
            if (citiesByCountry.ContainsKey(countryId))
            {
                return citiesByCountry[countryId].Select(city => new SelectListItem
                {
                    Value = city,
                    Text = city
                });
            }
            return new List<SelectListItem>();
        }
    }
}
