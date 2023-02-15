namespace Mayande.Models.Charts
{
    public struct CandlestickWrapper
    {
        public int Step { get; set; }
        public bool IsLastStep { get; set; }
        public CandlestickInfo CandlestickInfo { get; set; }
        public Candlestick[] GetRollingWindow()
        {
            var candlestickArray = new Candlestick[] {
                new Candlestick()
                {
                    Open = 10703.00f,
                    High = 10707.70f,
                    Low = 10697.60f,
                    Close = 10697.60f,
                    Volume = 917,
                }
            };

            var highestPrice = double.MinValue;
            var lowestPrice = double.MaxValue;

            foreach (var candlestick in candlestickArray)
            {
                if (candlestick.High > highestPrice)
                {
                    highestPrice = candlestick.High;
                }

                if (candlestick.Low < lowestPrice)
                {
                    lowestPrice = candlestick.Low;
                }
            }

            CandlestickInfo = new CandlestickInfo()
            {
                HighestPrice = highestPrice,
                Spread = highestPrice - lowestPrice,
            };

            return candlestickArray;
        }
    }
}
