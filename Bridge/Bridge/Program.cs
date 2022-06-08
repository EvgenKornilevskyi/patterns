namespace DesignPatterns.Bridge
{
    class Program
    {
        public static void Main(string[] args)
        {
            var client = new Client();

            var beverageDelivery = new BeverageDelivery(new BlackCoffee(2));

            client.OrderInside(beverageDelivery);

            client.OrderOutside(beverageDelivery);
        }
    }
}