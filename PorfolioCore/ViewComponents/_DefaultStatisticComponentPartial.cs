using Microsoft.AspNetCore.Mvc;
using PorfolioCore.Context;

namespace PorfolioCore.ViewComponents
{
    public class _DefaultStatisticComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var stats = context.Statistics.ToList();

            if (stats.Count >= 4)
            {
                var random = new Random();
                stats[3].StatisticValue = random.Next(10, 21);
            }

            return View(stats);
        }

    }
}
