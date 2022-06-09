namespace DesignPatterns.Strategy
{
    public class PayPalPayment : IPayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Making PayPal payment...");
        }
    }
}
