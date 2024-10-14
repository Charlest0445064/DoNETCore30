using Microsoft.AspNetCore.Mvc.Rendering;


namespace MVCApp.Dtos
{
    public class DepartmentViewModel
    {
        // 選中的選項（多選）
        public List<int> SelectedItems { get; set; }

        // 可供選擇的選項
        public List<SelectListItem> AvailableItems { get; set; }
    }
}
