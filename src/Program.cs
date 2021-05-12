using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Diagnostics;


namespace Practice
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(XO("xXoo"));

        }
        public static bool XO(string input)
        {
            var countx = input.ToLower().Count(x => x == 'x');
            var counto = input.ToLower().Count(o => o == 'o');
            return countx != counto ? false : true;
        }
    }
}




