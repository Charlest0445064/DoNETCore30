using Identity.Models;

namespace Identity.ViewModel
{
    public class CombineViewModel
    {
        public News News { get; set; }
        public List<News> NewsList { get; set; }
        public Employee Employee { get; set; }
        public List<Employee> EmployeeList { get; set; }
    }
}
