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
            Console.WriteLine(Persistence(39));
            Console.WriteLine(Persistence(999));
            Console.WriteLine(Persistence(0));
        }
        public static int Persistence(int n, int count = 1)
        {
            var charArray = n.ToString().ToCharArray();
            if (charArray.Length == 1) return 0;
            int prod = 1;
            foreach(var num in charArray)
            {
                prod = (int)Char.GetNumericValue(num) * prod;
            }
            if (prod.ToString().Length != 1) {
                count++;
                return Persistence(prod, count);}
            else return count;
        }
    }
}




