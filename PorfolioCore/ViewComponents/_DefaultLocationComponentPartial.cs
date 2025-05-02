using Microsoft.AspNetCore.Mvc;
using PorfolioCore.Context;

namespace PorfolioCore.ViewComponents
{
    public class _DefaultLocationComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }
    }
}
