using Microsoft.AspNetCore.Mvc.Filters;

namespace MVCApp.Filter
{
    public class MyActionFilter1 : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine("MyActionFilter1 前代碼");
            ActionExecutedContext result = await next();

            if (result.Exception != null)
            {
                Console.WriteLine("MyActionFilter1 發生異常");
            }
            else
            {
                Console.WriteLine("MyActionFilter1 執行正常");
            }
        }
    }
}
