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
            int[] arr = { 1, 2, 3, 4, 3, 2, 1 };

            Console.WriteLine(findIndex(arr));

        } //take that array and find an index N where the sum of the integers to the left of N is equal to the sum of the integers to the right of N. If there is no index that would make this happen, return -1.
        public static int findIndex(int[] arr)
        {
            int answer = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                int a = i + 1;
                int[] first = arr[i..];
                int[] second = arr[..a];
                if (first.Sum() == second.Sum())
                {
                    answer = i;
                    break;
                }
            }
            return answer;
        }


    }
}




