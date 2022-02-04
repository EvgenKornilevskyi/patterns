namespace FactoryMethodPattern
{
    public class AUDIFactory : CarFactory
    {
        public override ICar Create()
        {
            return new AUDI();
        }
    }
}
