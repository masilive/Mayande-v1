namespace Mayande.Models.Charts
{
    public struct Candlestick
    {
        public DateTime Timestamp { get; set; }
        public float Open { get; set; }
        public float High { get; set; }
        public float Low { get; set; }
        public float Close { get; set; }
        public float Volume { get; set; }
        public string Points { get; set; }
        public string GetCandleColor()
        {
            return Open > Close ? "red" : "lime";
        }
    }
    public struct Candlesticks
    {
        public static Candlestick[] GetRollingWindow()
        {
            return new Candlestick[] {
                new Candlestick() { Points = "50,50 30,70 50,100 70,70 50,50" }
            };
        }
    }
}
