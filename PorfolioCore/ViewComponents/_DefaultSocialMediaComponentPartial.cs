using Microsoft.AspNetCore.Mvc;
using PorfolioCore.Context;
using PorfolioCore.Migrations;

namespace PorfolioCore.ViewComponents
{
    public class _DefaultSocialMediaComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }
    }
}
