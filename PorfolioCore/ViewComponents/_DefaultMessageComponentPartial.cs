using Microsoft.AspNetCore.Mvc;
using PorfolioCore.Entities;

namespace PorfolioCore.ViewComponents
{
    public class _DefaultMessageComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View(new Message());
        }
    }
}
