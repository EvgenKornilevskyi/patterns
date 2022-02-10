namespace CoffeeShop
{
    public class CappuccinoJacobs : ICoffeeType
    {
        public int CostPrice { get; set; }
        public int SellPrice { get; set; }

        public void DrinkCoffee()
        {
            Console.WriteLine("Drink: Cappuccino Jacobs");
        }
    }
}
