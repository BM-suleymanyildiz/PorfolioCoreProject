using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PorfolioCore.Context;

namespace PorfolioCore.ViewComponents
{
    public class _DefaultSkillComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Skills.ToList();
            return View(value);
        }
    }
}
