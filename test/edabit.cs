using System;
using Xunit;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Globalization;

namespace Tests
{
    public class edabit
    {

        /// <summary>
        ///  Takes a string and returns a string with spaces in between all of the characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Method36(string s)
        {
            var answer = string.Empty;
            foreach (var c in s)
            {
                    answer += c + " ";
            }

            return answer.Trim();
        }
        /// <summary>
        /// Takes an array of 10 numbers (between 0 and 9) and returns a string of those numbers formatted as a phone number (e.g. (555) 555-5555).
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Method35(int[] a)
        {
            var sb = new StringBuilder();
            sb.Append('(');
            sb.Append($"{a[0]}{a[1]}{a[2]}");
            sb.Append(") ");
            sb.Append($"{a[3]}{a[4]}{a[5]}-");
            sb.Append($"{a[6]}{a[7]}{a[8]}{a[9]}");

            return sb.ToString();
        }

        /// <summary>
        /// Stutters a word as if someone is struggling to read it.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Method34(string s)
        {
            return (s[0].ToString() + s[1].ToString()) + "... " + (s[0].ToString() + s[1].ToString()) + "... " + s + "?";
        }

        /// <summary>
        /// Adds two words together and capatilize the first letter
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Method33(string a, string b)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(a + b);
        }
        public static string Method33b(string a, string b) => char.ToUpper(a[0]) + a.Substring(1) + b;
        public static string Method33c(string a, string b) => a.First().ToString().ToUpper() + string.Join("", a.Skip(1)) + b;


        /// <summary>
        /// Takes a word and returns true if the word has two consecutive identical letters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool Method32(string s)
        {
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    return true;
                }
            }
            return false;
        }



        /// <summary>
        /// Takes a string, checks if it has the same number of x's and o's and returns either true or false.
        /// </summary>
        /// <returns></returns>
        public static bool Method31(string s)
        {
            if (s.Contains("x") && s.Contains("o"))
            {
                return s.ToLower().Count(x => x == 'o') == s.ToLower().Count(y => y == 'x');
            }
            else return true;
        }

        /// <summary>
        /// Takes an array of strings and returns the words that are exactly four letters.
        /// </summary>
        /// <returns></returns>
        public static string[] Method30(string[] arr)
        {
            return arr.Where(x => x.Length == 4).ToArray();
        }

        /// <summary>
        /// returns the next number greater than a and b and divisible by b. A will always be greater than b.
        /// </summary>
        /// <returns></returns>
        public static int Method29b(int a, int b)
        {
            int c = a;
            while (c % b != 0)
            {
                c++;
            }
            return c;
        }
        public static int Method29(int a, int b) => a % b == 0 ? a : Method29(a + 1, b);

        /// <summary>
        /// Recursively finds the sum of the first n natural numbers.
        /// </summary>
        /// <returns></returns>
        public static int Method28(int n) => n == 1 ? 1 : n + Method28(n - 1);

        /// <summary>
        /// Takes a number and returns that given number of Rs in the word Burp
        /// </summary>
        /// <returns></returns>
        public static string Method27(int n)
        {
            return "Bu" + String.Concat(Enumerable.Repeat("r", n)) + "p";
        }

        /// <summary>
        ///  Takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.
        /// </summary>
        /// <returns>In order to work properly, the function should replace all "a"s with 4, "e"s with 3, "i"s with 1, "o"s with 0, and "s"s with 5.</returns>
        public static string Method26(string s)
        {
            return s.Replace('a', '4').Replace('e', '3').Replace('i', '1').Replace('o', '0').Replace('s', '5');
        }

        /// <summary>
        /// Returns the number of hashes and pluses in a string
        /// </summary>
        /// <returns></returns>
        public static int[] Method25(string s)
        {
            if (s == "") return new[] { 0, 0 };
            return new[] { s.ToCharArray().Count(x => x == '#'), s.ToCharArray().Count(y => y == '+') };
        }

        /// <summary>
        /// Takes an array of numbers and returns only the even values
        /// </summary>
        /// <returns></returns>
        public static int[] Method24b(int[] arr)
        {
            var answer = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                { answer.Add(arr[i]); }
            }
            return answer.ToArray();
        }
        public static int[] Method24(int[] arr) => arr.Where(x => x % 2 == 0).ToArray();

        /// <summary>
        /// Takes in two numbers and returns the percentage of the first over the second
        /// </summary>
        /// <returns></returns>
        public static string Method23(int a, int b)
        {
            return Math.Ceiling(100M * a / b).ToString() + "%";
        }

         /// <summary>
        /// Take an array and return an array with the same numbers sorted from lowest to highest
        /// </summary>
        /// <returns></returns>
        public static int[] Method22(int[] arr)
        {
            if (arr.Count() == 0) return Array.Empty<int>();
            return arr.OrderBy(x => x).ToArray();
        }

        /// <summary>
        /// Takes a number and returns the name of a shape with that many sides.
        /// </summary>
        /// <returns></returns>
        public static string Method21(int num)
        {
            return num switch
                {
                    1 => "circle",
                    2 => "semi-circle",
                    3 => "triangle",
                    4 => "square",
                    5 => "pentagon",
                    6 => "hexagon",
                    7 => "heptagon",
                    8 => "octagon",
                    9 => "nonagon",
                    10 => "decagon",
                    _ => "Not a shape."
                }; 
        }

        /// <summary>
        /// Takes a string and returns it in reverse
        /// </summary>
        /// <returns></returns>
        public static string Method20(string s)
        {
            var sb = new StringBuilder();
            var answer = s.ToArray().Reverse();
            foreach (var c in answer)
            {
                sb.Append(c);
            }
            return sb.ToString();
        }
        public static string Method20b(string s) => string.Concat(s.Reverse());


        /// <summary>
        /// Takes a string and a number and returns a string repeated n number of times
        /// </summary>
        /// <returns></returns>
        public static string Method19(string s, int n)
        {
            if (n == 1) return s;
            return s + Method19(s, n-1);
        }

        /// <summary>
        /// Returns the selected filename from a path. Include the extension in your answer.
        /// </summary>
        /// <returns></returns>
        public static string Method18(string path)
        {
            return path.Split('/').Last();
        }
        public static string Method18b(string path) => Path.GetFileName(path);

        /// <summary>
        ///  Takes an integer and returns the factorial of that integer. That is, the integer multiplied by all positive lower integers.
        /// </summary>
        /// <returns></returns>
        public static long Method17(long n) => n == 1 ? 1 : n * Method17(n - 1);
        public static long Method17b(long n)
        {
            if (n < 1) return 0;
            if (n == 1) return 1;
            return n * Method17b(n - 1);
        }

        /// <summary>
        /// Multiplies all of the values in an array by the amount of values in the given array.
        /// </summary>
        /// <returns></returns>
        public static int[] Method16(int[] arr)
        {
            return arr.Select(x => x * arr.Length).ToArray();
        }

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