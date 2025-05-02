using Microsoft.AspNetCore.Mvc;
using PorfolioCore.Context;

namespace PorfolioCore.ViewComponents
{
    public class _DefaultCategoryComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Categories.ToList();
            return View(values);
        }
    }
}
