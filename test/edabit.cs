using System;
using Xunit;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Tests
{
    public class edabit
    {   
/*      /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int Method()
        {

        }*/

        /// <summary>
        /// takes a base number and an exponent number and returns the calculation.
        /// </summary>
        /// <returns></returns>
        public static long Method15(long n, long x)
        {
            return Convert.ToInt64(Math.Pow(n, x));
        }

        /// <summary>
        /// Takes a string and returns the number (count) of vowels contained within it.
        /// </summary>
        /// <returns></returns>
        public static int Method14(string s)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (vowels.Any(x => x == s[i]))
                {
                    count ++;
                }
            }
            return count;
        }

        public static int Method14b(string s) => s.Count(a => $"aeiouAEIOU".Contains(a));

        /// <summary>
        /// Takes a string and returns a string in which each character is repeated once.
        /// </summary>
        /// <returns></returns>
        public static string Method13(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                sb.Append(s[i]);
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
            
        public static string Method13b(string s) => string.Concat(s.Select(c => $"{c}{c}"));

        /// <summary>
        /// Takes a number as an argument and returns "Fizz", "Buzz" or "FizzBuzz".
        /// </summary>
        /// <returns></returns>
        public static string Method12(int n)
        {
            if(n % 3  == 0 && n % 5 == 0)
            {return "FizzBuzz";}
            else if(n % 3 == 0)
            {return "Fizz";}
            else if (n % 5 == 0)
            {return "Buzz";}
            else return n.ToString();
        }

        /// <summary>
        /// Create a function that converts a date formatted as MM/DD/YYYY to YYYYDDMM.
        /// </summary>
        /// <returns>A String</returns>
        public static string Method11(string d)
        {
            var s = d.Split('/');
            return s[2] + s[1] + s[0];
        }

        public static string Method11b(string d) => String.Join("",d.Split('/').Reverse());

        public static string Method11c(string d) => Convert.ToDateTime(d).ToString("yyyyddMM");

        /// <summary>
        /// Removes the first and last characters from a string.
        /// </summary>
        /// <returns>If the string is 2 or fewer characters long, return the string itself.</returns>
        public static string Method10(string s)
        {
            if(s.Length < 3){
                return s;
            }
            string answer = string.Empty;
            for (int i = 1; i < s.Length -1; i++)
            {
                answer += s[i];
            }
            return answer;
        }

        public static string Method10b(string s) => s.Length <= 2 ? s : s.Substring(1, s.Length - 2);

        /// <summary>
        /// Counts how many D's are in a sentence
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Method9(string s) => s.Count(x => x == 'D' || x =='d');

        /// <summary>
        /// Returns true if an input string contains only uppercase or only lowercase letters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool Method8(string s)
        {
            return s.All(x => Char.IsUpper(x)) || s.All(x => Char.IsLower(x));
        }

        /// <summary>
        /// Return how many claps are in a sentance
        /// </summary>
        /// <param name="claps"></param>
        /// <returns></returns>
        public static int Method7(string claps)
        {
            return claps.Count(c => c == 'C');
        }

        /// <summary>
        /// Computes the number of characters that differ between two strings.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Method6(string a, string b)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] != b[i]){
                    count ++;
                }
            }
            return count;
        }

        public static int Method6b(string a, string b) => a.Where((t, x) => t != b[x]).Count();

        /// <summary>
        /// Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Method5(int[] arr)
        { 
            return arr.Select(x => Math.Abs(x)).Sum();
        }

        /// <summary>
        /// Returns the smaller number of two strings
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string Method4(string a, string b)
        {
            int c, d;
            if (int.TryParse(a, out c) && int.TryParse(b, out d)){
                return c < d ? c.ToString() : d.ToString();
            }
            else return "nope";
        }

        public static string Method4b(string n1, string n2) => Int32.Parse(n1) > Int32.Parse(n2) ? n2 : n1;
        
        /// <summary>
        /// Takes an array of numbers and return both the minimum and maximum numbers
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] Method3(int[] arr)
        {
            int[] answer = new int[2];
            answer[0] = arr.Min();
            answer[1] = arr.Max();
            return answer;
        }

        public static int[] Method3b(int[] arr) => new[] {arr.Min(), arr.Max()};

        /// <summary>
        /// Returns true if all characters in a string are identical
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool Method2(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[0] != s[i])
                {  
                    return false; 
                }
            }
            return true;
        }

        public static bool Method2b(string s) => s.All(x => x == s[0]);

        public static bool Method2c(string s) => s.Distinct().Count() == 1;

        /// <summary>
        /// Takes a number (from 1 to 12) and returns its corresponding month name as a string
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string Method1(sbyte num)
        {
            return num switch
                {
                    1 => "January",
                    2 => "February",
                    3 => "March",
                    4 => "April",
                    5 => "May",
                    6 => "June",
                    7 => "July",
                    8 => "August",
                    9 => "September",
                    10 => "October",
                    11 => "November",
                    12 => "December",
                    _ => "Not on the Calendar"
                };            
        }
    }
}