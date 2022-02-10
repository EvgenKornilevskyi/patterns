namespace CoffeeShop
{
    public interface ICoffeeType
    {
        public int CostPrice { get; set; }
        public int SellPrice { get; set; }
        public void DrinkCoffee();
    }
}
