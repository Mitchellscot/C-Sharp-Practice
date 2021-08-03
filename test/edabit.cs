using System;
using Xunit;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace edabit
{
    public class edabit
    {   
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

        /// <summary>
        /// Computes the number of characters that differ between two string - Linq version
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns the smaller of two strings
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Takes an array of numbers and return both the minimum and maximum numbers - with anonymous function
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns true if all characters in a string are identical - Linq version 1
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool Method2b(string s) => s.All(x => x == s[0]);

        /// <summary>
        /// Returns true if all characters in a string are identical - Linq version 2
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
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