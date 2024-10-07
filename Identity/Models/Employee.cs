using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Display(Name = "員工姓名")]
        public string Name { get; set; }
        [Display(Name = "部門編號")]
        public int DepartmentId { get; set; }
    }
}
