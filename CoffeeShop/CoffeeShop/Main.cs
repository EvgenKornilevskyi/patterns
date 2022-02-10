namespace CoffeeShop
{
    public static class Main
    {
        public static void Run()
        {
            var coffeeFactory = new List<ICoffeeFactory>
            {
                new CoffeeFactoryJacobs(),
                new CoffeeFactoryNescafe()
            };

            var rnd = new Random();

            var receipt = new List<ICoffeeType>();

            foreach(var factory in coffeeFactory)
            {
                for (var i = 0; i < rnd.Next(0, 10); i++)
                {
                    receipt.Add(factory.createEspresso());
                }
                for (var i = 0; i < rnd.Next(0, 10); i++)
                {
                    receipt.Add(factory.createAmericano());
                }
                for (var i = 0; i < rnd.Next(0, 10); i++)
                {
                    receipt.Add(factory.createCappuccino());
                }
                for (var i = 0; i < rnd.Next(0, 10); i++)
                {
                    receipt.Add(factory.createLatte());
                }
            }

            var totalIncome = 0;

            foreach (var good in receipt)
            {
                totalIncome += good.SellPrice;
            }

            Console.WriteLine(totalIncome);

        }
    }
}
