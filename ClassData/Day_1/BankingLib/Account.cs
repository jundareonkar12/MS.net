using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{

    public class Account
    {

        private string holder;
        public string Holder
        {
            get { return holder; }
            set { holder = value; }
        }
        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account() { }
        public Account(double amount)
        {
            balance = amount;
        }
        public void Withdraw(double amount)
        {
            balance -= amount;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
    }

}
