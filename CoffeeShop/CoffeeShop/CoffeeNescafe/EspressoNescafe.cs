namespace CoffeeShop
{
    public class EspressoNescafe : ICoffeeType
    {
        public int CostPrice { get; set; }
        public int SellPrice { get; set; }

        public void DrinkCoffee()
        {
            Console.WriteLine("Drink: Espresso Nescafe");
        }
    }
}
