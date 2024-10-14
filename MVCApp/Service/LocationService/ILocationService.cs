using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCApp.Service.LocationService
{
    public interface ILocationService
    {
        IEnumerable<SelectListItem> GetCountries();
        IEnumerable<SelectListItem> GetCitiesByCountryId(int countryId);
    }
}
