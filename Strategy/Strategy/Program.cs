namespace DesignPatterns.Strategy
{
    class Program
    {
        public static void Main(string[] args)
        {
            var paymentOperator = new Context();

            paymentOperator.SetPayment(new PayPalPayment());

            paymentOperator.MakePayment();
        }
    }
}