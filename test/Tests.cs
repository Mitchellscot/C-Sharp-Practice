using System;
using Xunit;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using static Tests.edabit;

namespace Tests
{
    public class Tests
    {   

        //public void Test30()
        //{
        //    var actual = "";
        //    var expected = "";
        //    Assert.Equal(expected, Method30(actual));
        //} 
        //public void Test29()
        //{
        //    var actual = "";
        //    var expected = "";
        //    Assert.Equal(expected, Method29(actual));
        //} 
        //public void Test28()
        //{
        //    var actual = "";
        //    var expected = "";
        //    Assert.Equal(expected, Method28(actual));
        //} 
        //public void Test27()
        //{
        //    var actual = "";
        //    var expected = "";
        //    Assert.Equal(expected, Method27(actual));
        //} 
        //public void Test26()
        //{
        //    var actual = "";
        //    var expected = "";
        //    Assert.Equal(expected, Method26(actual));
        //} 
        //public void Test25()
        //{
        //    var actual = "";
        //    var expected = "";
        //    Assert.Equal(expected, Method25(actual));
        //} 
        //public void Test24()
        //{
        //    var actual = "";
        //    var expected = "";
        //    Assert.Equal(expected, Method24(actual));
        //} 
        //public void Test23()
        //{
        //    var actual = "";
        //    var expected = "";
        //    Assert.Equal(expected, Method23(actual));
        //} 
        //public void Test22()
        //{
        //    var actual = "";
        //    var expected = "";
        //    Assert.Equal(expected, Method22(actual));
        //} */
        //public void Test21()
        //{
        //    var actual = "";
        //    var expected = "";
        //    Assert.Equal(expected, Method21(actual));
        //} 
        //public void Test20()
        //{
        //    var actual = "";
        //    var expected = "";
        //    Assert.Equal(expected, Method20(actual));
        //} 
        public void Test19()
        {
            var actual = "ab";
            var actualNum = 3;
            var expected = "ababab";
            Assert.Equal(expected, Method19(actual, actualNum));
            var actual2 = "kiwi";
            var actualNum2 = 1;
            var expected2 = "kiwi";
            Assert.Equal(expected2, Method19(actual2, actualNum2));
            var actual3 = "cherry";
            var actualNum3 = 4;
            var expected3 = "cherrycherry";
            Assert.Equal(expected3, Method19(actual3, actualNum3));
        }

        [Fact]
        public void Test18()
        {
            Assert.Equal("txt", Method18("C:/Projects/pil_tests/ascii/txt"));
            Assert.Equal("Beethoven_5.mp3", Method18("C:/Users/johnsmith/Music/Beethoven_5.mp3"));
            Assert.Equal("ffprobe.exe", Method18("ffprobe.exe"));
        }

        [Fact]
        public void Test17()
        {
            Assert.Equal(6, Method17(3));
            Assert.Equal(120, Method17(5));
            Assert.Equal(6227020800, Method17(13));
            Assert.Equal(0, Method17b(-5));
        }

        [Fact]
        public void Test16()
        {
            int[] actual1 = new int[4] {2, 3, 1, 0};
            int[] expected1 = new int[4] {8, 12, 4, 0};
            Assert.Equal(expected1, Method16(actual1));
            int[] actual2 = new int[3] {4, 1, 1};
            int[] expected2 = new int[3] {12,3,3};
            Assert.Equal(expected2, Method16(actual2));
            int[] actual3 = new int[7] {1, 0, 3, 3, 7, 2, 1};
            int[] expected3 = new int[7] {7, 0, 21, 21, 49, 14, 7};
            Assert.Equal(expected3, Method16(actual3));
            int[] actual4 = new int[1] {0};
            int[] expected4 = new int[1] {0};
            Assert.Equal(expected4, Method16(actual4));
        } 

        [Fact]
        public void Test15()
        {
            Assert.Equal(3125, Method15(5, 5));
            Assert.Equal(10000000000, Method15(10, 10));
            Assert.Equal(27, Method15(3, 3));
        }

        [Fact]
        public void Test14()
        {
            Assert.Equal(5, Method14("Celebration"));
            Assert.Equal(1, Method14("Palm"));
            Assert.Equal(4, Method14("Prediction"));
            Assert.Equal(3, Method14b("Mitchell Scott"));
        }

        [Fact]
        public void Test13()
        {
            Assert.Equal("SSttrriinngg", Method13("String"));
            Assert.Equal("HHeelllloo  WWoorrlldd!!", Method13("Hello World!"));
            Assert.Equal("11223344!!__  ", Method13b("1234!_ "));
        }

        [Fact]
        public void Test12()
        {
            Assert.Equal("Fizz", Method12(3));
            Assert.Equal("Buzz", Method12(5));
            Assert.Equal("FizzBuzz", Method12(15));
            Assert.Equal("4", Method12(4));
        } 

        [Fact]
        public void Test11()
        {
            Assert.Equal("20191211", Method11("11/12/2019"));
            Assert.Equal("20193112", Method11b("12/31/2019"));
            Assert.Equal("20191501", Method11c("01/15/2019"));
        }

        [Fact]
        public void Test10()
        {
            Assert.Equal("ell", Method10("Hello"));
            Assert.Equal("ayb", Method10("Maybe"));
            Assert.Equal("enefi", Method10b("Benefit"));
            Assert.Equal("a", Method10("a"));
        }

        [Fact]
        public void Test9()
        {
            Assert.Equal(4, Method9("My friend Dylan got distracted in school."));
            Assert.Equal(3, Method9("Debris was scattered all over the yard."));
            Assert.Equal(3, Method9("The rodents hibernated in their den."));
        }

        [Fact]
        public void Test8()
        {
            Assert.True(Method8("hello"));
            Assert.True(Method8("HELLO"));
            Assert.False(Method8("Hello"));
            Assert.False(Method8("ketcHUp"));
        }

        [Fact]
        public void Test7()
        {
            Assert.Equal(4, Method7("ClaClaClaClap!"));
            Assert.Equal(6, Method7("ClClClaClaClaClap!"));
            Assert.Equal(9, Method7("CCClaClClap!Clap!ClClClap!"));
        }

        [Fact]
        public void Test6()
        {
            Assert.Equal(0, Method6("abcde", "abcde"));
            Assert.Equal(1, Method6("abcde", "absde"));
            Assert.Equal(2, Method6b("abmcdz", "abmsdq"));
            Assert.Equal(5, Method6b("abcde", "bcdef"));
        }

        [Fact]
        public void Test5()
        { 
            int[] testArray = {1, -2, 3, -4, 5};
            Assert.Equal(15, Method5(testArray));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal("5", Method4("5", "6"));
            Assert.Equal("5", Method4("6", "5"));
            Assert.Equal("9078", Method4b("107838", "9078"));
            Assert.Equal("9078", Method4b("107838", "9078"));
        }
       
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

        [Fact]
        public void Test2()
        {
            Assert.True(Method2("aaaaa"));
            Assert.False(Method2b("aaabaaa"));
            Assert.False(Method2c("mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmn"));
            Assert.False(Method2c("nmmmmmmmmm"));
            Assert.True(Method2c("z"));
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
//public void Test30()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method30(actual));
//} 
//public void Test29()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method29(actual));
//} 
//public void Test28()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method28(actual));
//} 
//public void Test27()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method27(actual));
//} 
//public void Test26()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method26(actual));
//} 
//public void Test25()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method25(actual));
//} 
//public void Test24()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method24(actual));
//} 
//public void Test23()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method23(actual));
//} 
//public void Test22()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method22(actual));
//} */
//public void Test21()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method21(actual));
//} 
//public void Test20()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method20(actual));
//} 