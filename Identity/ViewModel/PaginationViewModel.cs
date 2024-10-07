namespace Identity.ViewModel
{
    public class PaginationViewModel
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }

        // 總頁數
        public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);
    }
}
