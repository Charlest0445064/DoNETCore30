using Microsoft.VisualBasic;
using MVCApp.CustomValidation;
using MVCApp.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MVCApp.Dtos
{
    [DateRangeValidation]
    public class NewsCreateDto
    {
        [Display(Name = "標題")]
        [Required(ErrorMessage = "標題不可為空")]
        public string Title { get; set; }
        [Display(Name = "內容")]
        [Required(ErrorMessage = "標題不可為空")]
        public string Contents { get; set; }
        [Display(Name = "部門")]
        [Required(ErrorMessage = "部門不可為空")]
        public int DepartmentId { get; set; }

        
        [Display(Name = "開始時間")]
        [Required(ErrorMessage = "開始時間不可為空")]
        [DataType(DataType.Date)]
        public DateTime StartDateTime { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        [Display(Name = "結束時間")]
        [Required(ErrorMessage = "結束時間不可為空")]
        public DateTime? EndDateTime { get; set; } = null;
        public List<Department> DepList { get; set; } = new List<Department>();
    }
}
