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
            string str = "-100 2 300 4 5";
            List<int> answer = new List<int>();
            var arr = str.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                answer.Add(int.Parse(arr[i]));
            }
            int highest = answer.Max();
            int lowest = answer.Min();
            WriteLine($"{lowest.ToString()} {highest.ToString()}");
        }
    }
}




