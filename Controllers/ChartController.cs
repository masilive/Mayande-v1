using Microsoft.AspNetCore.Mvc;

namespace Mayande.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
