using Microsoft.AspNetCore.Mvc;

namespace PorfolioCore.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
