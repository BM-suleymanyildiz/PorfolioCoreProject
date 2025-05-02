using Microsoft.AspNetCore.Mvc;
using PorfolioCore.Context;
namespace PorfolioCore.ViewComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
    }
}
