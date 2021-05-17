using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class NamedAndOpionalParam
    {
        static void Main2(string[] args) 
        {
            //Console.WriteLine(NamedAndOpionalParam.GetFullName(lastName: "Mohite", firstName: "Pratik"));

            Addition(10, 20);
            Addition(10);       // when do not pass value for optional param its default value mentioned in function is used
        }
        static string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        static void Addition(int a, int b = 0)      // optional parameter should be at the end of list
        {
            Console.WriteLine(a+b);
        }
    }
}
