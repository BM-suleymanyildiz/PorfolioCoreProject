using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PorfolioCore.Context;

namespace PorfolioCore.ViewComponents
{
    public class _DefaultProjectComponentPartial: ViewComponent
    {
        PortfolioContext context=new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values=context.Portfolios.ToList();
            return View(values);
        }
        public IViewComponentResult GetProjectWithCategory(int id)
        {
            var values = context.Portfolios.Include(p => p.Category).Where(p => p.CategoryId == id).ToList();

            return View(values);
        }
    }
}
