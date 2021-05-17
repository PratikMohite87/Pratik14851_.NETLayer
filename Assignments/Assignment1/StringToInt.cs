using System;

namespace Assignment1
{
    class StringToInt
    {
        static void Main1(string[] args)
        {
            string str = null;

            /*int a;
            Boolean b = int.TryParse(str, out a);       // will return true if string gets converted into int and vice-versa
            Console.WriteLine(b+"  "+a);*/

            try
            {
                int c = int.Parse(str);     // if conversion fails then throws exception.   // it also not allow null value if fed null value will throw exception.
                Console.WriteLine(c);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);      // exception- Input string was not in correct fromat
            }

            try
            {
                int d = Convert.ToInt32(str);       // if conversion fails then throws exception // it allows null value converts it to 0
                Console.WriteLine(d);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
