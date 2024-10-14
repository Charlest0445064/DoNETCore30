using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace MVCApp.HtmlHelper
{
    public static class HtmlHelperExtensions
    {
        // 這裡的 `T` 是下拉選單中的項目類型，可以是任意的，例如: string, int
        public static IHtmlContent CustomDropDownList<T>(
            this IHtmlHelper htmlHelper,
            string name,                    // 下拉選單的名稱 (id 名稱)
            IEnumerable<T> items,           // 下拉選單的項目集合
            string optionLabel,             // 可選的提示標籤，例如 "請選擇..."
            object htmlAttributes = null)   // 可選的 HTML 樣式屬性
        {
            // 構建下拉選單的項目列表
            var selectList = new SelectList(items);

            // 使用內置的 DropDownList 方法來生成 HTML
            return htmlHelper.DropDownList(name, selectList, optionLabel, htmlAttributes);
        }
    }
}
