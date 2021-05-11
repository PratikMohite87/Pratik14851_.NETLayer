using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Saving : Bank, IInterest
    {
        public Saving()
        { }

        public Saving(string name, int amount) : base(name, amount)     // invoking parent class parmeterized constructor.
        { }

        public double CalculateInterest()
        {
            throw new NotImplementedException();
        }

        public override void Withdraw(int amount)
        {
            //base.Withdraw(amount); // calling parent class method.

            if ((Balance-amount) >= 0)
            {
                Balance -= amount;
            }
            else 
            {
                // its not a wise idea to pass a message using Console.WriteLine() as it will give error in case of web application, so best way is to throw error.
                throw new BalanceException("Insufficient Balance");        // custom exception class
            }
        }
    }
}
