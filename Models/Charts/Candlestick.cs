namespace Mayande.Models.Charts
{
    public struct Candlestick
    {
        public DateTime Timestamp { get; set; }
        public float Open { get; set; }
        public float High { get; set; }
        public float Low { get; set; }
        public float Close { get; set; }
        public ushort Volume { get; set; }
        public string GetCandleColor()
        {
            return Open > Close ? "red" : "lime";
        }
        public string GetPolyPoints(CandlestickInfo candlestickInfo, ushort index)
        {
            return CandlestickHelper.CalculatePolyPoints(index, this, candlestickInfo.ChartHeight, candlestickInfo.HighestPrice, candlestickInfo.Spread);
        }
    }
}
