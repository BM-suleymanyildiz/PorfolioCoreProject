using Microsoft.AspNetCore.Mvc;

namespace PorfolioCore.ViewComponents
{
    public class _DefaultScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
