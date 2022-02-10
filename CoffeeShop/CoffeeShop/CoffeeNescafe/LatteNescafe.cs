namespace CoffeeShop
{
    public class LatteNescafe : ICoffeeType
    {
        public int CostPrice { get; set; }
        public int SellPrice { get; set; }

        public void DrinkCoffee()
        {
            Console.WriteLine("Drink: Latte Nescafe");
        }
    }
}
