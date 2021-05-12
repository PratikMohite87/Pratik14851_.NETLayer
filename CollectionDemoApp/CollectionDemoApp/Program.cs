using System;
using System.Collections;       // contains all collection classes
using System.Collections.Generic;       // contains generic clsses.

namespace CollectionDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList

            ArrayList country = new ArrayList();        
            country.Add("India");
            country.Add("USA");
            country.Add("UK");
            country.Insert(1,"France");     // insert value at specified index
            country.Add(100);       // its heterogenous
            country.Add(true);

            foreach (string cntry in country)
                Console.WriteLine(cntry);

            for (int i = 0; i < country.Count; i++)
            {
                Console.WriteLine(country[i]);
            }


            // Object initializer
            //Person person = new Person() { FirstName = "Pratik", LastName = "Mohite" };     // curve bracket are optional     // its ok if there is no parameterized constructor in Person class

            country.Add(new Person { FirstName = "Darshana", LastName = "Bhoir" });

            Console.WriteLine(((Person)country[6]).FirstName);      // here as collection classes stores objects in Object form will getting back we need to type cast them.
                                                                    // This leads to performance degradation, so concept of Generic collection was introduced.
                                                                    // In projects also we tends to use generic classes.

            #endregion

            #region Generic

            List<string> str = new List<string>();
            List<int> str1 = new List<int>();
            List<Person> str2 = new List<Person>();

            #endregion

            #region Nullable

            // nullable type works with only value type

            int num = 10;
            //num = null;     // error connot convert null to int, value type cannot work will null

            Nullable<int> x = null;     // works
            int? y = null;      // shortcut

            if (x.HasValue)
                Console.WriteLine(x);
            else
                Console.WriteLine("x is a null");

            Console.WriteLine(x.GetValueOrDefault(0) + y.GetValueOrDefault(0));         // if null then default value will be used

            #endregion
        }
    }
}
