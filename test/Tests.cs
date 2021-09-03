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
        //public void Test40()
        //{
        //    var actual = "";
        //    var expected = "";
        //    Assert.Equal(expected, Method40(actual));
        //} 
        //public void Test39()
        //{
        //    var actual = "";
        //    var expected = "";
        //    Assert.Equal(expected, Method39(actual));
        //} 
        //public void Test38()
        //{
        //    var actual = "";
        //    var expected = "";
        //    Assert.Equal(expected, Method38(actual));
        //} 
        //public void Test37()
        //{
        //    var actual = "";
        //    var expected = "";
        //    Assert.Equal(expected, Method37(actual));
        //} 
        //public void Test36()
        //{
        //    var actual = "";
        //    var expected = "";
        //    Assert.Equal(expected, Method36(actual));
        //} 
        [Fact]
        public void Test36()
        {
            var actual = "space";
            var expected = "s p a c e";
            Assert.Equal(expected, Method36(actual));
            var actual1 = "far out";
            var expected1 = "f a r   o u t";
            Assert.Equal(expected1, Method36(actual1));
            var actual2 = "elongated musk";
            var expected2 = "e l o n g a t e d   m u s k";
            Assert.Equal(expected2, Method36(actual2));
        }
        [Fact]
        public void Test35()
        {
            var actual = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            var expected = "(123) 456-7890";
            Assert.Equal(expected, Method35(actual));
            var actual1 = new[] { 5, 1, 9, 5, 5, 5, 4, 4, 6, 8 };
            var expected1 = "(519) 555-4468";
            Assert.Equal(expected1, Method35(actual1));
            var actual2 = new[] { 3, 4, 5, 5, 0, 1, 2, 5, 2, 7 };
            var expected2 = "(345) 501-2527";
            Assert.Equal(expected2, Method35(actual2));
        }
        [Fact]
        public void Test34()
        {
            var actual = "incredible";
            var expected = "in... in... incredible?";
            Assert.Equal(expected, Method34(actual));
            var actual1 = "enthusiastic";
            var expected1 = "en... en... enthusiastic?";
            Assert.Equal(expected1, Method34(actual1));
            var actual2 = "outstanding";
            var expected2 = "ou... ou... outstanding?";
            Assert.Equal(expected2, Method34(actual2));
        }
        [Fact]
        public void Test33()
        {
            var actuala = "seas";
            var actualb = "onal";
            var expected = "Seasonal";
            Assert.Equal(expected, Method33(actuala, actualb));
            var actuala1 = "comp";
            var actualb1 = "lete";
            var expected1 = "Complete";
            Assert.Equal(expected1, Method33(actuala1, actualb1));
            var actuala2 = "lang";
            var actualb2 = "uage";
            var expected2 = "Language";
            Assert.Equal(expected2, Method33(actuala2, actualb2));
            var actuala3 = "mitc";
            var actualb3 = "hell";
            var expected3 = "Mitchell";
            Assert.Equal(expected3, Method33(actuala3, actualb3));
        }
        [Fact]
        public void Test32()
        {
            var actual = "loop";
            var actual1 = "yummy";
            var actual2 = "orange";
            var actual3 = "munchkin";
            Assert.True(Method32(actual));
            Assert.True(Method32(actual1));
            Assert.False(Method32(actual2));
            Assert.False(Method32(actual3));

        }
        [Fact]
        public void Test31()
        {
            var actual = "ooxx";
            Assert.True(Method31(actual));
            var actual1 = "xooxx";
            Assert.False(Method31(actual1));
            var actual2 = "ooxXm";
            Assert.True(Method31(actual2));
            var actual3 = "zpzpzpp";
            Assert.True(Method31(actual3));
        }
        [Fact]
        public void Test30()
        {
            var actual = new[] { "Tomato", "Potato", "Pair" };
            var expected = new[] {"Pair" };
            Assert.Equal(expected, Method30(actual));
            var actual1 = new[] {"Kangaroo", "Bear", "Fox" };
            var expected1 = new[] {"Bear" };
            Assert.Equal(expected1, Method30(actual1));
            var actual2 = new[] { "Ryan", "Kieran", "Jason", "Matt" };
            var expected2 = new[] { "Ryan", "Matt" };
            Assert.Equal(expected2, Method30(actual2));
        }
        [Fact]
        public void Test29()
        {
            var actual = 17;
            var actualb = 8;
            var expected = 24;
            Assert.Equal(expected, Method29(actual, actualb));
            var actual1 = 98;
            var actualb1 = 3;
            var expected1 = 99;
            Assert.Equal(expected1, Method29(actual1, actualb1));
            var actual2 = 14;
            var actualb2 = 11;
            var expected2 = 22;
            Assert.Equal(expected2, Method29(actual2, actualb2));
        }
        [Fact]
        public void Test28()
        {
            var actual = 5;
            var expected = 15;
            Assert.Equal(expected, Method28(actual));
            var actual2 = 1;
            var expected2 = 1;
            Assert.Equal(expected2, Method28(actual2));
            var actual3 = 12;
            var expected3 = 78;
            Assert.Equal(expected3, Method28(actual3));
        }
        [Fact]
        public void Test27()
        {
            var actual = 3;
            var expected = "Burrrp";
            Assert.Equal(expected, Method27(actual));
            var actual2 = 5;
            var expected2 = "Burrrrrp";
            Assert.Equal(expected2, Method27(actual2));
            var actual3 = 9;
            var expected3 = "Burrrrrrrrrp";
            Assert.Equal(expected3, Method27(actual3));
        }
    [Fact]
        public void Test26()
        {
            var actual = "javascript is cool";
            var expected = "j4v45cr1pt 15 c00l";
            Assert.Equal(expected, Method26(actual));
            var actual1 = "programming is fun";
            var expected1 = "pr0gr4mm1ng 15 fun";
            Assert.Equal(expected1, Method26(actual1));
            var actual2 = "become a coder";
            var expected2 = "b3c0m3 4 c0d3r";
            Assert.Equal(expected2, Method26(actual2));
        }
        [Fact]
        public void Test25()
        {
            var actual = "###+";
            var expected = new[] {3, 1 };
            Assert.Equal(expected, Method25(actual));
            var actual1 = "##+++#";
            var expected1 = new[] { 3, 3 };
            Assert.Equal(expected1, Method25(actual1));
            var actual2 = "#+++#+#++#";
            var expected2 = new[] { 4, 6 };
            Assert.Equal(expected2, Method25(actual2));
        }
        [Fact]
        public void Test24()
        {
            var actual = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var expected = new int[]{2, 4, 6, 8};
            Assert.Equal(expected, Method24(actual));
            var actual1 = new int[] { 43, 65, 23, 89, 53, 9, 6 };
            var expected1 = new int[] { 6 };
            Assert.Equal(expected1, Method24(actual1));
            var actual2 = new int[] {718, 991, 449, 644, 380, 440};
            var expected2 = new int[] { 718, 644, 380, 440 };
            Assert.Equal(expected2, Method24(actual2));
        }
        [Fact]
        public void Test23()
        {
            var actuala = 1;
            var actualb = 10;
            var expected = "10%";
            Assert.Equal(expected, Method23(actuala, actualb));
            var actual1a = 2;
            var actual1b = 5;
            var expected1 = "40%";
            Assert.Equal(expected1, Method23(actual1a, actual1b));
            var actual2a = 1;
            var actual2b = 8;
            var expected2 = "13%";
            Assert.Equal(expected2, Method23(actual2a, actual2b));
        }
        [Fact]
        public void Test22()
        {
            var actual = new int[] { 1, 2, 10, 50, 5 };
            var expected = new int[] { 1, 2, 5, 10, 50 };
            Assert.Equal(expected, Method22(actual));
            var actual2 = new int[] { 80, 29, 4, -95, -24, 85 };
            var expected2 = new int[] { -95, -24, 4, 29, 80, 85 };
            Assert.Equal(expected2, Method22(actual2));
            var actual3 = Array.Empty<int>();
            var expected3 = Array.Empty<int>();
            Assert.Equal(expected3, Method22(actual3));
        }
        [Fact]
        public void Test21()
        {
            var actual = 3;
            var expected = "triangle";
            Assert.Equal(expected, Method21(actual));
            var actual2 = 1;
            var expected2 = "circle";
            Assert.Equal(expected2, Method21(actual2));
            var actual3 = 9;
            var expected3 = "nonagon";
            Assert.Equal(expected3, Method21(actual3));
        }

        [Fact]
        public void Test20()
        {
            var actual = "Hello World";
            var expected = "dlroW olleH";
            Assert.Equal(expected, Method20(actual));
            var actual2 = "The quick brown fox.";
            var expected2 = ".xof nworb kciuq ehT";
            Assert.Equal(expected2, Method20(actual2));
            var actual3 = "Edabit is really helpful!";
            var expected3 = "!lufpleh yllaer si tibadE";
            Assert.Equal(expected3, Method20b(actual3));
        }
        [Fact]
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
            var expected3 = "cherrycherrycherrycherry";
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

//public void Test40()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method29(actual));
//} 
//public void Test39()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method28(actual));
//} 
//public void Test38()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method27(actual));
//} 
//public void Test37()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method26(actual));
//} 
//public void Test36()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method25(actual));
//} 
//public void Test35()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method24(actual));
//} 
//public void Test34()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method23(actual));
//} 
//public void Test33()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method22(actual));
//} */
//public void Test32()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method21(actual));
//} 
//public void Test31()
//{
//    var actual = "";
//    var expected = "";
//    Assert.Equal(expected, Method20(actual));
//} 