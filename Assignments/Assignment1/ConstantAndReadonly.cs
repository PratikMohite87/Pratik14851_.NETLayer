using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class ConstantAndReadonly
    {
        static void Main(string[] args)
        {
            const int rollNo = 24;      // you have to initialize constant variable while declaration.

            //rollNo = 4;       reassigning value to const variable is not allowed will give CTE

            ReadOnly ro = new ReadOnly("Hello");
        }
    }

    class ReadOnly
    {
        readonly int rollNo = 24;       // you have to initalize readonly member while declaration or in constructor.

        readonly int age;

        readonly string name = "Pratik";

        public ReadOnly(string name)
        {
            age = 20;
            name = "Mhite";     // readonly fields can be initialize or reinitialize in constructor;
        }

        public void ChangeName(string newName)
        {
            //name = "xyz";       // will give error cannot reinitalize
        }
    }
}
