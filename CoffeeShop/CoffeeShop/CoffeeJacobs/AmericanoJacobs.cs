namespace CoffeeShop
{
    public class AmericanoJacobs : ICoffeeType
    {
        public int CostPrice { get; set; }
        public int SellPrice { get; set; }

        public void DrinkCoffee()
        {
            Console.WriteLine("Drink: Americano Jacobs");
        }
    }
}
