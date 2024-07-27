namespace PaymentService
{
    public interface IPaymentStrategy
    {
        public void Pay(double amount);
        public void CheckBalance();
        public void IncreaseBalance(double amount);
    }
}
