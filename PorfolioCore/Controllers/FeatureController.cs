using Microsoft.AspNetCore.Mvc;
using PorfolioCore.Context;
using PorfolioCore.Entities;

namespace PorfolioCore.Controllers
{
    public class FeatureController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult FeatureList()
        {
            var values = context.Features.ToList();
            return View(values);
        }

    
        public IActionResult DeleteFeature(int id)
        {
            var value = context.Features.Find(id);
            context.Features.Remove(value);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }


        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var value = context.Features.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateFeature(Feature p)
        {
            context.Features.Update(p);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}
