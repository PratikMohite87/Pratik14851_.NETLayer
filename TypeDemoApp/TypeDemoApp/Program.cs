using System;

namespace TypeDemoApp
{
    class Program
    {
        enum Months
        {
            jan=1,feb,march,april,june,july,aug,sept,oct,nov,dec    // setting value to 1 instead of zero
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DayOfWeek.Monday+" - "+(int)DayOfWeek.Monday);
            Console.WriteLine(DayOfWeek.Sunday+" - "+(int)DayOfWeek.Sunday);        // ENUM strats with 0 index, you can set it to equating it to one

            Console.WriteLine((int)Months.jan);
        }
    }
}
