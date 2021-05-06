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
            WriteLine(IsPangram("The quick brown fox jumps over the lazy dog"));

        }
        public static bool IsPangram(string str)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            foreach (var letter in alphabet)
            {
                if (!str.ToLower().Contains(letter))
                {
                    return false;
                }
            }
            return true;
        }
    }
}




