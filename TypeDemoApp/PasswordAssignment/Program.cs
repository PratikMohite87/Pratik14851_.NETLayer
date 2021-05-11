using System;

namespace PasswordAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidationClass vc = new ValidationClass();

            int count = vc.PasswordStrength(Console.ReadLine());

            switch (count)
            {
                case 0: Console.WriteLine("5 char required");
                    break;

                case 1:
                    Console.WriteLine("Too Weak password");
                    break;

                case 2:
                    Console.WriteLine("Weak password");
                    break;

                case 3:
                    Console.WriteLine("Average password");
                    break;

                case 4:
                    Console.WriteLine("Strong password");
                    break;
            }
        }
    }
}
