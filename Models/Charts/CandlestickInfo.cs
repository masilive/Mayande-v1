namespace Mayande.Models.Charts
{
    public struct CandlestickInfo
    {
        public double ChartHeight { get; set; }
        public double HighestPrice { get; set; }
        public double Spread { get; set; }
        public CandlestickInfo(double chartHeight)
        {
            ChartHeight = chartHeight;
        }
        public CandlestickInfo(double chartHeight, double highestPrice, double spread)
        {
            ChartHeight = chartHeight;
            HighestPrice = highestPrice;
            Spread = spread;
        }
    }
}
