namespace FactoryMethodPattern
{
    public static class Main
    {
        public static void Run()
        {
            var carFactories = new List<CarFactory>
            {
                new BMWFactory(),
                new AUDIFactory(),
                new MAZDAFactory()
            };

            var cars = new List<ICar>();

            foreach (var factory in carFactories)
            {
                cars.Add(factory.Create());
            }

            foreach(var car in cars)
            {
                car.Drive();
            }
        }
    }
}
