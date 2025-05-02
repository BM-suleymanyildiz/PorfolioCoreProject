using Microsoft.AspNetCore.Mvc;

namespace PorfolioCore.ViewComponents
{
    public class _DeafaultPortfolioComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
