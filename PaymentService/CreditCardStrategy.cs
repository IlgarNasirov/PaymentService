using System.Diagnostics;

namespace PaymentService
{
    public class CreditCardStrategy : IPaymentStrategy
    {
        private double _balance;
        public CreditCardStrategy()
        {
            _balance = 1123;
        }
        public void CheckBalance()
        {
            Debug.WriteLine("Your Credit card balance: " + _balance);
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
                Debug.WriteLine("You have increased the amount in your Credit card account.");
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
                Debug.WriteLine("Your Credit card balance is insufficient.");
                CheckBalance();
            }
            else
            {
                CheckBalance();
                _balance -= amount;
                Debug.WriteLine("You have decreased the amount in your Credit card account.");
                CheckBalance();
            }
        }
    }
}
