namespace CoffeeShop
{
    public interface ICoffeeFactory
    {
        public ICoffeeType createEspresso();
        public ICoffeeType createAmericano();
        public ICoffeeType createCappuccino();
        public ICoffeeType createLatte();

    }
}
