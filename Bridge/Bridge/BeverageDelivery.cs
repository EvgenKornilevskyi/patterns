namespace DesignPatterns.Bridge
{
    public class BeverageDelivery : IBeverageDelivery
    {
        private readonly Beverage _beverage;
        public BeverageDelivery(Beverage beverage)
        {
            _beverage = beverage;
        }
        public void DeliverBeverageInside()
        {
            _beverage.Prepare();
            Console.WriteLine("Delivering beverage inside...");
            Console.WriteLine($"Price: {_beverage.Cost()}");
            _beverage.Drink();
        }
        public void DeliverBeverageOutside()
        {
            _beverage.Prepare();
            Console.WriteLine("Delivering beverage outside...");
            Console.WriteLine($"Price: {_beverage.Cost()}");
            _beverage.Drink();
        }
    }
}
