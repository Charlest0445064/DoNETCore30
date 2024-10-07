using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class News
    {
        public Guid NewsId { get; set; }
        [Display(Name = "標題")]
        public string Title { get; set; }
        [Display(Name = "內容")]
        public string Contents { get; set; }
        [Display(Name = "部門編號")]
        public int DepartmentId { get; set; }
        [Display(Name = "開始時間")]
        public DateTime StartDateTime { get; set; }
        [Display(Name = "結束時間")]
        public DateTime EndDateTime { get; set; }
        [Display(Name = "輸入時間")]
        public DateTime InsertDateTime { get; set; }
        [Display(Name = "輸入員工編號")]
        public int InsertEmployeeId { get; set; }
        [Display(Name = "更新時間")]
        public DateTime UpdateDateTime { get; set; }
        [Display(Name = "更新員工編號")]
        public int UpdateEmployeeId { get; set; }
        [Display(Name = "點擊次數")]
        public int Click { get; set; }
        [Display(Name = "是否啟用")]
        public bool Enable { get; set; }
    }
}
