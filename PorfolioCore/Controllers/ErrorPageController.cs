using Microsoft.AspNetCore.Mvc;

namespace PorfolioCore.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
    }
}
