using Microsoft.AspNetCore.Mvc;
using PorfolioCore.Context;

namespace PorfolioCore.ViewComponents
{
    public class _DefaultResumeComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Resumes.ToList();
            return View(value);
        }
    }
}
