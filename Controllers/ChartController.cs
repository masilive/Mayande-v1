using Microsoft.AspNetCore.Mvc;
using Mayande.Models.Charts;

namespace Mayande.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View(Candlesticks.GetRollingWindow());
        }
    }
}
