using System;

namespace BankLibrary
{
    public abstract class Bank
    {
        private string accountHoldrName;    // field

        public string AccountHolderName     // property
        {
            set { accountHoldrName = value; }
            get { return accountHoldrName; }
        }

        private double balance;

        public double Balance
        {
            protected set { balance = value; }      // mixed access specifier.
            get { return balance; }
        }

        private static int counter;

        public static int Counter
        {
            set { counter = value; }
            get { return counter; }
        }

        // By default methods inside class are sealed not allowed to override, to carry out we have to mark them virtual.

        public void Deposit(int amount)
        {
            balance += amount;
        }

        public abstract void Withdraw(int amount);

        //public virtual void Withdraw(int amount)    // now this method is available for overriding.
        //{
            //balance -= amount;
        //}

        static Bank()   // static constructor for initializing static members
        {
            Counter = 10;
        }

        public Bank()
        {
            Balance = 10000;
            Counter++;
        }

        public Bank(string name, int balance) : this()    // counstructor chaining
        {
            Balance = balance;
            AccountHolderName = name;
        }

        public override string ToString()
        {
            return string.Format($"Account Holder Name is {accountHoldrName} and balance is {balance}");
        }
    }
}
