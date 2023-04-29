using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPAY.Model
{
    public class CpayAccount
    {
        private decimal balance;

        public CpayAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }
        
        public decimal Deposit(decimal amount)
        {
            balance += amount;
            return balance;
        }

        public decimal Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return balance;

            }
            else
            {
                throw new Exception("Insufficient funds");
            }

        }

        public decimal Balance
        {
            get { return balance; }
        }
    }
}
