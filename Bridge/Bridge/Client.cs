namespace DesignPatterns.Bridge
{
    public class Client
    {
        public void OrderInside(BeverageDelivery beverageDelivery)
        {
            beverageDelivery.DeliverBeverageInside();
        }
        public void OrderOutside(BeverageDelivery beverageDelivery)
        {
            beverageDelivery.DeliverBeverageOutside();
        }
    }
}
