using System;

namespace InBuiltDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Action
            /*
            Action action = Display1;       // Encapsulates a method that can have no parameters to upto 16 parameters i.e Action<t1...t16> and
            action();                       // does not return a value.
            */
            #endregion

            #region Func
            /*
            // it can accept no paramters to upto 16 parameters
            // method must have return type, it can be of any type.
            Func<string> func = Display2;
            Console.WriteLine(func());

            Func<int, int, int> func1 = Display3;
            Console.WriteLine(func1(1, 3));
            */
            #endregion

            #region Predicate

            // return must be allways boolean
            // method should allways take only 1 parameter.

            /*
            Predicate<string> predicate = Display4;
            Console.WriteLine(predicate("Pratik"));
            */
            #endregion

            /*
            Class1 class1 = new Class1();
            class1.Ac = EventHandler;
            class1.Number = 0;
            */

            #region Anonymous
            Func<string, string, string> anonymous = delegate (string firstName, string lastName)
            {
                return firstName + lastName;
            };

            Console.WriteLine(anonymous("Pratik", "Mohite"));
            #endregion

            #region Lambda

            Func<int, int> lambda = (int a) =>
            {
                return a;
            };

            Console.WriteLine(lambda(1));
            #endregion


        }

        static void Display1()
        {
            Console.WriteLine("Display1");
        }

        static string Display2()
        {
            return "Hello";
        }

        static int Display3(int a, int b)
        {
            return a * b;
        }

        static bool Display4(string a)
        {
            return false;
        }

        static void EventHandler()
        {
            Console.WriteLine("Event is handled");
        }
    }
}
