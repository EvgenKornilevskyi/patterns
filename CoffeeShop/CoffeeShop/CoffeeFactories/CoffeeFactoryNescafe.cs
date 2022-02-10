namespace CoffeeShop
{
    public class CoffeeFactoryNescafe : ICoffeeFactory
    {
        public ICoffeeType createAmericano()
        {
            return new AmericanoNescafe
            {
                CostPrice = 25,
                SellPrice = 30
            };
        }

        public ICoffeeType createCappuccino()
        {
            return new CappuccinoNescafe
            {
                CostPrice = 35,
                SellPrice = 40
            };
        }

        public ICoffeeType createEspresso()
        {
            return new EspressoNescafe
            {
                CostPrice = 25,
                SellPrice = 30
            };
        }

        public ICoffeeType createLatte()
        {
            return new LatteNescafe
            {
                CostPrice = 35,
                SellPrice = 40
            };
        }
    }
}
