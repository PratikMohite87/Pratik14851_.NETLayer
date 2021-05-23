using System;

namespace LearningApp
{
    class Program
    {
        public delegate void Deli1();       // creating signature of deligate, method signatures also needs to be same whih are going to get called using this delegate.
        public delegate void Deli2(int a, int b);
        public delegate int Deli3(int a, int b);
        static void Main(string[] args)
        {
            //Deli1 deli1 = new Deli1(Display1);      // creating object of delegate and passing method name whic you have to call as paramter.
            //deli1();        // will call the method passed as parameter.

            /*
            Deli1 deli2 = Display1;     // compiler will internally convert it to "Deli1 deli2 = new Deli1(Display1);"
            deli2();

            deli2 += Display2;
            deli2();
                                        // we can also call multiple method using same degligate object. Possible due to MultiCastDelegate Class.
            deli2 += Display3;
            deli2();

            deli2 -= Display2;          // we can also remove method from the delegates.
            deli2();
            */

            /*
            Deli1 deli4 = (Deli1)Delegate.Combine(new Deli1(Display1), new Deli1(Display2), new Deli1(Display3));
            deli4();

            Console.WriteLine("----------------------------------------------------------");

            deli4 = (Deli1)Delegate.Remove(deli4, new Deli1(Display2));
            deli4();

            Console.WriteLine("----------------------------------------------------------");

            deli4 += Display3;
            deli4();

            Console.WriteLine("----------------------------------------------------------");

            deli4 = (Deli1)Delegate.RemoveAll(deli4, new Deli1(Display3));
            deli4();
            */

            /*
            Deli2 deli5 = Display4;
            deli5(3, 5);

            Deli2 deli6 = Display5;
            deli6(2, 6);
            */

            //Deli3 deli7 = Display6;
            //Console.WriteLine(deli7(2,3));

            Deli1 deli8 = new DelegateClass().Display;
            deli8();
        }

        static void Display1()
        {
            Console.WriteLine("Display1");
        }
        static void Display2()
        {
            Console.WriteLine("Display2");
        }
        static void Display3()
        {
            Console.WriteLine("Display3");
        }

        static void Display4(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        static void Display5(int c, int d)
        {
            Console.WriteLine(c*d);
        }

        static int Display6(int c, int d)
        {
            return c * d;
        }
    }

    class DelegateClass
    {
        public void Display()
        {
            Console.WriteLine("Display from DelegateClass");
        }
    }
}
