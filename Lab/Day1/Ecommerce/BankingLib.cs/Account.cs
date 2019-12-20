using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
    public class Account
    {
        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public double Withdraw(int bal)
        {
            balance -= bal;
            return balance;
        }
        public double Deposit(int bal)
        {
            balance += bal;
            return balance;
        }
        public override string ToString()
        {
            return "balance is:" + balance;
        }

    }

}
