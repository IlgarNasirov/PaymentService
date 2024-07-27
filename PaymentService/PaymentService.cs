namespace PaymentService
{
    public class PaymentService
    {
        private IPaymentStrategy _paymentStrategy;
        public PaymentService(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }
        public void CheckBalance()
        {
            _paymentStrategy.CheckBalance();
        }

        public void IncreaseBalance(double amount)
        {
            _paymentStrategy.IncreaseBalance(amount);
        }

        public void Pay(double amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}
