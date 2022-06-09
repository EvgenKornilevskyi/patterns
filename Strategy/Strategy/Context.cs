namespace DesignPatterns.Strategy
{
    public class Context
    {
        private IPayment _payment;
        public void SetPayment(IPayment payment)
        {
            _payment = payment;
        }
        public void MakePayment()
        {
            _payment.MakePayment();
        }
    }
}
