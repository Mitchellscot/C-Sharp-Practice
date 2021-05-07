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
        long n = 12345;
        var arr = n.ToString().ToCharArray();
        Array.Reverse(arr);
        var answer = arr.Select(x => Convert.ToInt64(Char.GetNumericValue(x))).ToArray();
        foreach (var item in answer)
        {
            WriteLine(item.ToString());
        }
        
        }
    }
}




