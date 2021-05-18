using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    static class ExtensionMethod
    {
        // 1. write static method
        //2. 1st parameter of ststic method should have this keyword.

        public static int wordCount(this string str)
        {
            return str.Split(" ").Length;
        }
    }
}
