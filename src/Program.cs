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
           Func<int, int> square = x => x*x;
           var z = int.Parse(ReadLine());
           System.Console.WriteLine(square(z).ToString());

        }

    }
}




