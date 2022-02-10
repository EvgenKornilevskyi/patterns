namespace CoffeeShop
{
    public class CoffeeFactoryJacobs : ICoffeeFactory
    {
        public ICoffeeType createAmericano()
        {
            return new AmericanoJacobs
            {
                CostPrice = 15,
                SellPrice = 20
            };
        }

        public ICoffeeType createCappuccino()
        {
            return new CappuccinoJacobs
            {
                CostPrice = 20,
                SellPrice = 25
            };
        }

        public ICoffeeType createEspresso()
        {
            return new EspressoJacobs
            {
                CostPrice = 15,
                SellPrice = 20
            };
        }

        public ICoffeeType createLatte()
        {
            return new LatteJacobs
            {
                CostPrice = 20,
                SellPrice = 25
            };
        }
    }
}
