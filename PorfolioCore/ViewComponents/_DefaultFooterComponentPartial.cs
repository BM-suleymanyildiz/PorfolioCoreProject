using Microsoft.AspNetCore.Mvc;

namespace PorfolioCore.ViewComponents
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
