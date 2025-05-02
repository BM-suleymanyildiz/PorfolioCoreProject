using Microsoft.AspNetCore.Mvc;

namespace PorfolioCore.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
