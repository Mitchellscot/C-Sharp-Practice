using System;
using Xunit;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace edabit
{
    public class edabit
    {   
/*      /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int Method()
        {

        }

        [Fact]
        public void Test()
        {

        } */

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

        [Fact]
        public void Test13()
        {
            Assert.Equal("SSttrriinngg", Method13("String"));
            Assert.Equal("HHeelllloo  WWoorrlldd!!", Method13("Hello World!"));
            Assert.Equal("11223344!!__  ", Method13b("1234!_ "));
        }

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

        [Fact]
        public void Test12()
        {
            Assert.Equal("Fizz", Method12(3));
            Assert.Equal("Buzz", Method12(5));
            Assert.Equal("FizzBuzz", Method12(15));
            Assert.Equal("4", Method12(4));
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

        [Fact]
        public void Test11()
        {
            Assert.Equal("20191211", Method11("11/12/2019"));
            Assert.Equal("20193112", Method11b("12/31/2019"));
            Assert.Equal("20191501", Method11c("01/15/2019"));
        }

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

        [Fact]
        public void Test10()
        {
            Assert.Equal("ell", Method10("Hello"));
            Assert.Equal("ayb", Method10("Maybe"));
            Assert.Equal("enefi", Method10b("Benefit"));
            Assert.Equal("a", Method10("a"));
        }

        /// <summary>
        /// Counts how many D's are in a sentence
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Method9(string s) => s.Count(x => x == 'D' || x =='d');

        [Fact]
        public void Test9()
        {
            Assert.Equal(4, Method9("My friend Dylan got distracted in school."));
            Assert.Equal(3, Method9("Debris was scattered all over the yard."));
            Assert.Equal(3, Method9("The rodents hibernated in their den."));
        }
        /// <summary>
        /// Returns true if an input string contains only uppercase or only lowercase letters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool Method8(string s)
        {
            return s.All(x => Char.IsUpper(x)) || s.All(x => Char.IsLower(x)) ? true : false;
        }

        [Fact]
        public void Test8()
        {
            Assert.True(Method8("hello"));
            Assert.True(Method8("HELLO"));
            Assert.False(Method8("Hello"));
            Assert.False(Method8("ketcHUp"));
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

        [Fact]
        public void Test7()
        {
            Assert.Equal(4, Method7("ClaClaClaClap!"));
            Assert.Equal(6, Method7("ClClClaClaClaClap!"));
            Assert.Equal(9, Method7("CCClaClClap!Clap!ClClClap!"));
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

        [Fact]
        public void Test6()
        {
            Assert.Equal(0, Method6("abcde", "abcde"));
            Assert.Equal(1, Method6("abcde", "absde"));
            Assert.Equal(2, Method6b("abmcdz", "abmsdq"));
            Assert.Equal(5, Method6b("abcde", "bcdef"));
        }

        /// <summary>
        /// Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Method5(int[] arr)
        { 
            return arr.Select(x => Math.Abs(x)).Sum();
        }

        [Fact]
        public void Test5()
        { 
            int[] testArray = {1, -2, 3, -4, 5};
            Assert.Equal(15, Method5(testArray));
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

        [Fact]
        public void Test4()
        {
            Assert.Equal("5", Method4("5", "6"));
            Assert.Equal("5", Method4("6", "5"));
            Assert.Equal("9078", Method4b("107838", "9078"));
            Assert.Equal("9078", Method4b("107838", "9078"));
        }
        
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
        
        [Fact]
        public void Test3()
        {
            int[] a = {1, 50};
            int[] b = {6, 1, 45, 50};
            Assert.Equal(a, Method3(b));
            int[] c = {-99, 209};
            int[] d = {3, 54, -99, 209, 34, 75, -3, -45};
            Assert.Equal(c, Method3b(d));
        }

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

        [Fact]
        public void Test2()
        {
            Assert.True(Method2("aaaaa"));
            Assert.False(Method2b("aaabaaa"));
            Assert.False(Method2c("mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmn"));
            Assert.False(Method2c("nmmmmmmmmm"));
            Assert.True(Method2c("z"));
        }

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

        [Fact]
        public void Test1()
        {
            Assert.Equal("April", Method1(4));
            Assert.Equal("November", Method1(11));
            Assert.Equal("December", Method1(12));
            Assert.Equal("Not on the Calendar", Method1(13));
        }
    }
}