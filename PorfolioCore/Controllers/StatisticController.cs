using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PorfolioCore.Context;
using PorfolioCore.Entities;

namespace PorfolioCore.Controllers
{
    public class StatisticController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        private List<SelectListItem> GetIconList()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Text = "MutluYuz", Value = "bi bi-emoji-smile" },
                new SelectListItem { Text = "Projeler", Value = "bi bi-journal-richtext" },
                new SelectListItem { Text = "HourofSupport", Value = "bi bi-headset" },
                new SelectListItem { Text = "Hardworkes", Value = "bi bi-people" }
            };
        }


        public IActionResult StatisticList()
        {
            var values = context.Statistics.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateStatistic()
        {
            ViewBag.IconList = GetIconList();
            return View();
        }
        [HttpPost]
        public IActionResult CreateStatistic(Statistic stats)
        {
            context.Statistics.Add(stats);
            context.SaveChanges();
            ViewBag.IconList = GetIconList();
            return RedirectToAction("StatisticList");
        }
        public IActionResult DeleteStatistic(int id)
        {
            var value = context.Statistics.Find(id);
            context.Statistics.Remove(value);
            context.SaveChanges();
            return RedirectToAction("StatisticList");
        }
        [HttpGet]
        public IActionResult UpdateStatistic(int id)
        {
            var value = context.Statistics.Find(id);
            ViewBag.IconList = GetIconList();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateStatistic(Statistic stats)
        {
            context.Statistics.Update(stats);
            context.SaveChanges();
            ViewBag.IconList = GetIconList();
            return RedirectToAction("StatisticList");
        }
    }
}
