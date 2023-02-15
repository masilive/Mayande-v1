using System.Text;

namespace Mayande.Models.Charts
{
    public class CandlestickHelper
    {
        private static readonly ushort _candleVMargin = 14;
        private static readonly ushort _candleHMargin = 8;
        private static readonly ushort _candleHPadding = 1;
        private static readonly ushort _candleHSpacing = 7;
        private static readonly ushort _candleBodyWidth = 2;
        private static readonly ushort _candleWickWidth = 1;
        public static string CalculatePolyPoints(ushort index, Candlestick candlestick, double chartHeight, double maxValue, double spread)
        {
            var upperWick = GetRelativeValue(candlestick.High, maxValue, chartHeight, spread) + _candleVMargin;
            var upperBody = GetRelativeValue(Math.Max(candlestick.Open, candlestick.Close), maxValue, chartHeight, spread) + _candleVMargin;
            var lowerBody = GetRelativeValue(Math.Min(candlestick.Open, candlestick.Close), maxValue, chartHeight, spread) + _candleVMargin;
            var lowerWick = GetRelativeValue(candlestick.Low, maxValue, chartHeight, spread) + _candleVMargin;

            if (upperBody == lowerBody)
            {
                lowerBody--;
            }

            var candleX = _candleHMargin + _candleHPadding + (_candleHSpacing * index);

            StringBuilder points = new();
            points.Append($"{candleX + _candleBodyWidth},{upperWick} ");    // 1
            points.Append($"{candleX + _candleBodyWidth},{upperBody} ");    // 2
            points.Append($"{candleX},{upperBody} ");      // 3
            points.Append($"{candleX},{lowerBody} ");      // 4
            points.Append($"{candleX + _candleBodyWidth},{lowerBody} ");      // 5
            points.Append($"{candleX + _candleBodyWidth},{lowerWick} ");      // 6
            points.Append($"{candleX + _candleBodyWidth + _candleWickWidth},{lowerWick} ");      // 7
            points.Append($"{candleX + _candleBodyWidth + _candleWickWidth},{lowerBody} ");      // 8
            points.Append($"{candleX + _candleBodyWidth + _candleBodyWidth + _candleWickWidth},{lowerBody} ");      // 9
            points.Append($"{candleX + _candleBodyWidth + _candleBodyWidth + _candleWickWidth},{upperBody} ");      // 10
            points.Append($"{candleX + _candleBodyWidth + _candleWickWidth},{upperBody} ");      // 11
            points.Append($"{candleX + _candleBodyWidth + _candleWickWidth},{upperWick}");           // 12

            return points.ToString();
        }
        public static ushort GetPoints(Instrument instrument)
        {
            return instrument switch
            {
                Instrument.US100 => 1000,
                _ => 100,
            };
        }
        public static double GetRelativeValue(double value, double maxValue, double chartHeight, double spread, bool isPriceInfo = true)
        {
            return ((maxValue - value) / spread) * (isPriceInfo ? chartHeight - (_candleVMargin + _candleVMargin) : chartHeight);
        }
    }
}
