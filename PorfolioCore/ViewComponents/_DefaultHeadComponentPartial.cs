using Microsoft.AspNetCore.Mvc;

namespace PorfolioCore.ViewComponents
{
    public class _DefaultHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}