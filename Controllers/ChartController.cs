using Microsoft.AspNetCore.Mvc;
using Mayande.Models.Charts;

namespace Mayande.Controllers
{
    public class ChartController : Controller
    {
        private CandlestickWrapper _candlestickWrapper;
        public IActionResult Index()
        {
            _candlestickWrapper = new ();

            return View(_candlestickWrapper);
        }

        public Action? SetChartHeight(double chartHeight)
        {
            _candlestickWrapper.CandlestickInfo = new CandlestickInfo(chartHeight);

            return default;
        }
    }
}
