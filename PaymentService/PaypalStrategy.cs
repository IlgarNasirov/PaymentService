using System.Diagnostics;

namespace PaymentService
{
    public class PaypalStrategy : IPaymentStrategy
    {
        private double _balance;
        public PaypalStrategy()
        {
            _balance = 1234.67;
        }
        public void CheckBalance()
        {
            Debug.WriteLine("Your PayPal balance: " + _balance);
        }

        public void IncreaseBalance(double amount)
        {
            if (amount <= 0)
            {
                Debug.WriteLine("The amount field must me greater than zero.");
            }
            else
            {
                CheckBalance();
                _balance += amount;
                Debug.WriteLine("You have increased the amount in your PayPal account.");
                CheckBalance();
            }
        }

        public void Pay(double amount)
        {
            if (amount <= 0)
            {
                Debug.WriteLine("The amount field must me greater than zero.");
            }
            else
            if (amount > _balance)
            {
                Debug.WriteLine("Your PayPal balance is insufficient.");
                CheckBalance();
            }
            else
            {
                CheckBalance();
                _balance -= amount;
                Debug.WriteLine("You have decreased the amount in your PayPal account.");
                CheckBalance();
            }
        }
    }
}
