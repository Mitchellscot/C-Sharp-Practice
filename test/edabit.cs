using System;
using Xunit;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace edabit
{
    public class edabit
    {   
        //Create a function that computes the number of characters that differ between two strings. 
        [Fact]
        public void Test6()
        {
            Assert.Equal(0, Test6Mb("abcde", "abcde"));
            Assert.Equal(1, Test6Mb("abcde", "absde"));
            Assert.Equal(2, Test6Mb("abmcdz", "abmsdq"));
            Assert.Equal(5, Test6Mb("abcde", "bcdef"));
        }
        public static int Test6M(string a, string b)
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
        //linq version
        public static int Test6Mb(string a, string b)
        {
            return a.Where((t, x) => t != b[x]).Count();
        }
        //Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.
        [Fact]
        public void Test5()
        { 
            int[] testArray = {1, -2, 3, -4, 5};
            Assert.Equal(15, Test5M(testArray));
        }
        public static int Test5M(int[] arr)
        { 
            return arr.Select(x => Math.Abs(x)).Sum();
        }
        [Fact] //returns the smaller number of two
        public void Test4()
        {
            Assert.Equal("5", Test4M("5", "6"));
            Assert.Equal("5", Test4M("6", "5"));
            Assert.Equal("9078", Test4M("107838", "9078"));
            Assert.Equal("9078", Test4Mb("107838", "9078"));

        }
        public static string Test4M(string a, string b)
        {
            int c, d;
            if (int.TryParse(a, out c) && int.TryParse(b, out d)){
                return c < d ? c.ToString() : d.ToString();
            }
            else return "nope";
        }
        public static string Test4Mb(string n1, string n2)
        {
            return Int32.Parse(n1) > Int32.Parse(n2) ? n2 : n1;
        }
        [Fact] //takes an array of numbers and return both the minimum and maximum numbers
        public void Test3()
        {
            int[] a = {1, 50};
            int[] b = {6, 1, 45, 50};
            Assert.Equal(a, Test3M(b));
            int[] c = {-99, 209};
            int[] d = {3, 54, -99, 209, 34, 75, -3, -45};
            Assert.Equal(c, Test3Mb(d));
        }
        public static int[] Test3M(int[] arr)
        {
            int[] answer = new int[2];
            answer[0] = arr.Min();
            answer[1] = arr.Max();
            return answer;
        }
        public static int[] Test3Mb(int[] arr)
        {
            //using an anonymous function
            return new[] {arr.Min(), arr.Max()};
        }

        [Fact] //returns true if all characters in a string are identical 
        public void Test2()
        {
            Assert.True(Test2Ma("aaaaa"));
            Assert.False(Test2Mb("aaabaaa"));
            Assert.False(Test2Mc("mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmn"));
            Assert.False(Test2Mc("nmmmmmmmmm"));
            Assert.True(Test2Mc("z"));
        }

        public static bool Test2Ma(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[0] != s[i]){  return false; }
            }
            return true;
        }
        public static bool Test2Mb(string s)
        {
            return s.All(x => x == s[0]);
        }
        public static bool Test2Mc(string s)
        {
            //with linq, Distinct removes all that are duplicates, 
            //Count returns number in a collection
            //I suppose the equals makes it return a boolean
            return s.Distinct().Count() == 1;
        }

        [Fact] //takes a number (from 1 to 12) and returns its corresponding month name as a string
        public void Test1()
        {
            Assert.Equal("April", Test1M(4));
            Assert.Equal("November", Test1M(11));
            Assert.Equal("December", Test1M(12));
            Assert.Equal("Not on the Calendar", Test1M(13));

        }
        public static string Test1M(sbyte num)
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