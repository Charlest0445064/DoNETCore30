using Microsoft.AspNetCore.Mvc.Filters;

namespace MVCApp.Filter
{
    public class MyActionFilter2 : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine("MyActionFilter2 前代碼");
            ActionExecutedContext result = await next();

            if (result.Exception != null)
            {
                Console.WriteLine("MyActionFilter2 發生異常");
            }
            else
            {
                Console.WriteLine("MyActionFilter2 執行正常");
            }
        }
    }
}
