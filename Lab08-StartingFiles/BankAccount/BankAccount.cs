using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    class BankAccount
    {
        private string name;
        private int accnum;
        private DateTime opentime;

        protected decimal balance;

        public const string BankName = "Bank of Ontario";

        public string ClientName
        {
            get { return name; }
            set
            {
                if (value.Length > 0)
                {
                    name = value;
                }
                else
                {
                    name = "Unknown";
                }
            }
        }

        public int AccNumber
        {
             get { return accnum; }
        }

        public string OpenTime
        {
            get { return opentime.ToLongDateString(); }
        }

        public string Balance
        {
            get { return balance.ToString("c2"); }
        }

        public BankAccount(int accountNumber, decimal startBalance)
        {
            accnum = accountNumber;
            balance = startBalance;
            name = "Unknown";
            opentime = DateTime.Today;
        }

        public BankAccount(int accNumb, decimal startBal, string nameOfClient)
        {
            accnum = accNumb;
            balance = startBal;
            ClientName = nameOfClient;
            opentime = DateTime.Today;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                balance -= amount;
            }
        }
    }
}
