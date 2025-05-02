using Microsoft.AspNetCore.Mvc;
using PorfolioCore.Context;

namespace PorfolioCore.ViewComponents
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }
    }
}
