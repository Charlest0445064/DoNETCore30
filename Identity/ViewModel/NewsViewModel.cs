using Identity.Models;

namespace Identity.ViewModel
{
    public class NewsViewModel
    {
        public News col { get; set; }
        public List<News> News { get; set; }
        public PaginationViewModel Pagination { get; set; }
    }
}
