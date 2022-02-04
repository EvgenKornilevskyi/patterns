namespace FactoryMethodPattern
{
    public class BMWFactory : CarFactory
    {
        public override ICar Create()
        {
            return new BMW();
        }
    }
}
