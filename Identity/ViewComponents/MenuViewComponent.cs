using Microsoft.AspNetCore.Mvc;

namespace Identity.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // 模拟一些数据
            string model = "这是来自 ViewComponent 的数据";

            // 返回 ViewComponentResult，渲染视图并传递数据模型
            return View("Default",model);
        }
    }
}
