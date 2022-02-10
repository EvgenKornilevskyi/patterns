namespace CoffeeShop
{
    public class AmericanoNescafe : ICoffeeType
    {
        public int CostPrice { get; set; }
        public int SellPrice { get; set; }

        public void DrinkCoffee()
        {
            Console.WriteLine("Drink: Americano Nescafe");
        }
    }
}