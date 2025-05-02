using Microsoft.AspNetCore.Mvc;

namespace PorfolioCore.ViewComponents
{
    public class _DefaultSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
