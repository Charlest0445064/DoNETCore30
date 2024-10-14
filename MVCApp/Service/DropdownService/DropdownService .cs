namespace MVCApp.Service.DropdownService
{
    public class DropdownService : IDropdownService
    {
        public IEnumerable<string> GetDropdownItems()
        {
            // 這裡可以從資料庫獲取資料，這裡用靜態數據模擬
            return new List<string> { "選項1", "選項2", "選項3" };
        }
    }
}
