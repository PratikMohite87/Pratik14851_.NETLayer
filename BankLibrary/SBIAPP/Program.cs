using System;
using BankLibrary;

namespace SBIApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bank b1 = new Bank("pratik", 1000);
            //Console.WriteLine(b1.ToString());

            //Bank b2 = new Bank("pratik2", 1000);
            //Bank b3 = new Bank("pratik3", 1000);
            //Bank b4 = new Bank("pratik4", 1000);

            //Console.WriteLine(Bank.Counter);

            Saving s1 = new Saving("pratik", 1000);
            Console.WriteLine(s1.ToString());

            try
            {
                s1.Withdraw(500000);
            }
            catch (BalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
