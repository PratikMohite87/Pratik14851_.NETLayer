using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main1(string[] args)
        {
            //Thread t1 = new Thread(Increment);
            //Thread t2 = new Thread(Decrement);

            Thread t1 = new Thread(new ThreadStart(Increment));     // new ThreadStart is the delegate which points towards the function which will run when thread start executing 
            Thread t2 = new Thread(new ThreadStart(Decrement));

            t1.Start();
            /*t1.Join(); */     // next thread will start its execution once this thread is dead.
        
            t2.Start();
            
            Console.ReadLine();
        }

        static void Increment()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Increment : {0}", i);
            }
        }

        static void Decrement()
        {
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine("Decrement : {0}", i);
            }
        }
    }
}

namespace Threadss2
{
    class Program2
    {
        static void Main2()
        {
            Thread t = new Thread(new ThreadStart(Func1));
            /*t.IsBackground = false; */        // even though main completes it execution program will wait for the thread to complete its task and after completion onlu code will stop; 
            t.IsBackground = true;        // after the completion of execution of main thread the program will stop it will not wait for the thread to complete its task      // to avoid this use t.Join();
            t.Start();

            Console.WriteLine("Main Executed");

        }

        static void Func1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Increment : {0}", i);
            }
        }
    }
}

namespace Threadss3
{
    class Program3
    {
        static AutoResetEvent are = new AutoResetEvent(false);
        //static ManualResetEvent are = new ManualResetEvent(false);
        //static WaitHandle wh = new AutoResetEvent(false);

        static void Main3()
        {
            Thread t1 = new Thread(new ThreadStart(Increment));
            //Thread t2 = new Thread(new ThreadStart(Decrement));

            t1.Start();
            //t2.Start();

            //Console.ReadLine();
            are.Set();      // signals the stopped thread to start again from same point where it has stopped.

            //Console.ReadLine();
            are.Set();
        }

        static void Increment()
        {
            Console.WriteLine("Starting Increments");

            are.WaitOne();      // makes thread to wait until it gets signal by are.Set();

            Console.WriteLine("Stoping Increments");

            Console.WriteLine("Starting Increments");

            are.WaitOne();      // makes thread to wait until it gets signal by are.Set();

            Console.WriteLine("Stoping Increments");
        }
    }
}

namespace Threadss4
{
    class Program4
    {
        static void Main4()
        {
            //Thread t = new Thread(Func1);

            Thread t = new Thread(new ParameterizedThreadStart(Func1));
            t.Start("Pratik Mohite");

            Class1 c = new Class1(1, "Pratik Mohite");
            Thread t1 = new Thread(new ParameterizedThreadStart(Func2));
            t1.Start(c);

            Console.ReadLine();
        }

        static void Func1(Object o)
        {
            Console.WriteLine("This is func1");
            Console.WriteLine(o.ToString());
        }

        static void Func2(Object o)
        {
            Console.WriteLine("This is func2");
            Class1 c1 = (Class1)o;
            Console.WriteLine(c1.Name + " " + c1.No);
        }
    }

    class Class1
    {
        public int No { set; get; }
        public String Name { set; get; }

        public Class1(int No, String Name)
        {
            this.No = No;
            this.Name = Name;
        }
    }
}

namespace Taskss4
{
    class Program4
    {
        static void Main()
        {
            Func<String> f1 = func1;
            Task<string> t = new Task<string>(f1);
            t.Start();
            Console.WriteLine(t.Result);

            Func<Object, String> f2 = func2;
            Task<string> t2 = new Task<string>(f2, "Pratik Mohite");
            t2.Start();
            Console.WriteLine(t2.Result);

            Console.ReadLine();
        }

        static String func1()
        {
            return "Pratik Mohite";
        }

        static String func2(Object o)
        {
            return o.ToString();
        }
    }
}