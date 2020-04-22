using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bank
{
    using System;
    public class InsufficientFundsException : ApplicationException 
    { 
    } 
    public class Account
    {
        private float balance;
        public void Deposit(float amount)
        {
            balance += amount;
        }

        public void Withdraw(float amount)
        {
            balance -= amount;
        }
        public void TransferFunds(Account destination, float amount)
        {
            if (balance - amount < minimumBalance)
                throw new InsufficientFundsException(); 
            destination.Deposit(amount);
            Withdraw(amount);
        }

        public float Balance
        {
            get { return balance; }
        }
        private float minimumBalance = 10.00F; 
        public float MinimumBalance 
        {
            get { 
                return minimumBalance; 
            }
        } 
    }
    
}
