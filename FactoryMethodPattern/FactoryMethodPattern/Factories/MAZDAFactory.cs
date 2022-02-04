namespace FactoryMethodPattern
{
    public class MAZDAFactory : CarFactory
    {
        public override ICar Create()
        {
            return new MAZDA();
        }
    }
}
