using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MVCApp.Models;

namespace MVCApp.Components
{
    public class MyViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(Employee employee)
        {
            var content = new HtmlString("<h1>HtmlContentViewComponentResult</h1>");
            return new HtmlContentViewComponentResult(content);
        }
    }
}
