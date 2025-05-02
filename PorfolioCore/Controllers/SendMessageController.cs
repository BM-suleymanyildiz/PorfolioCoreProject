using Microsoft.AspNetCore.Mvc;
using PorfolioCore.Context;
using PorfolioCore.Entities;

namespace PorfolioCore.Controllers
{
    public class SendMessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        [HttpPost]
        public IActionResult SendMessages(Message message)
        {

            context.Messages.Add(message);
            context.SaveChanges();
            ViewBag.Success = "Gönderim işlemi başarılı!";
            return View("~/Views/Default/Index.cshtml");
        }
    }
}
