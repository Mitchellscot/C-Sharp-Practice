using System;
using Xunit;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class Tests
    {   

    /*    [Fact]
        public void Test()
        {

        } */

        [Fact]
        public void Test14()
        {
            Assert.Equal(5, edabit.Method14("Celebration"));
            Assert.Equal(1, edabit.Method14("Palm"));
            Assert.Equal(4, edabit.Method14("Prediction"));
            Assert.Equal(3, edabit.Method14b("Mitchell Scott"));

        }

        [Fact]
        public void Test13()
        {
            Assert.Equal("SSttrriinngg", edabit.Method13("String"));
            Assert.Equal("HHeelllloo  WWoorrlldd!!", edabit.Method13("Hello World!"));
            Assert.Equal("11223344!!__  ", edabit.Method13b("1234!_ "));
        }

        [Fact]
        public void Test12()
        {
            Assert.Equal("Fizz", edabit.Method12(3));
            Assert.Equal("Buzz", edabit.Method12(5));
            Assert.Equal("FizzBuzz", edabit.Method12(15));
            Assert.Equal("4", edabit.Method12(4));
        } 

        [Fact]
        public void Test11()
        {
            Assert.Equal("20191211", edabit.Method11("11/12/2019"));
            Assert.Equal("20193112", edabit.Method11b("12/31/2019"));
            Assert.Equal("20191501", edabit.Method11c("01/15/2019"));
        }

        [Fact]
        public void Test10()
        {
            Assert.Equal("ell", edabit.Method10("Hello"));
            Assert.Equal("ayb", edabit.Method10("Maybe"));
            Assert.Equal("enefi", edabit.Method10b("Benefit"));
            Assert.Equal("a", edabit.Method10("a"));
        }

        [Fact]
        public void Test9()
        {
            Assert.Equal(4, edabit.Method9("My friend Dylan got distracted in school."));
            Assert.Equal(3, edabit.Method9("Debris was scattered all over the yard."));
            Assert.Equal(3, edabit.Method9("The rodents hibernated in their den."));
        }

        [Fact]
        public void Test8()
        {
            Assert.True(edabit.Method8("hello"));
            Assert.True(edabit.Method8("HELLO"));
            Assert.False(edabit.Method8("Hello"));
            Assert.False(edabit.Method8("ketcHUp"));
        }

        [Fact]
        public void Test7()
        {
            Assert.Equal(4, edabit.Method7("ClaClaClaClap!"));
            Assert.Equal(6, edabit.Method7("ClClClaClaClaClap!"));
            Assert.Equal(9, edabit.Method7("CCClaClClap!Clap!ClClClap!"));
        }

        [Fact]
        public void Test6()
        {
            Assert.Equal(0, edabit.Method6("abcde", "abcde"));
            Assert.Equal(1, edabit.Method6("abcde", "absde"));
            Assert.Equal(2, edabit.Method6b("abmcdz", "abmsdq"));
            Assert.Equal(5, edabit.Method6b("abcde", "bcdef"));
        }

        [Fact]
        public void Test5()
        { 
            int[] testArray = {1, -2, 3, -4, 5};
            Assert.Equal(15, edabit.Method5(testArray));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal("5", edabit.Method4("5", "6"));
            Assert.Equal("5", edabit.Method4("6", "5"));
            Assert.Equal("9078", edabit.Method4b("107838", "9078"));
            Assert.Equal("9078", edabit.Method4b("107838", "9078"));
        }
       
        [Fact]
        public void Test3()
        {
            int[] a = {1, 50};
            int[] b = {6, 1, 45, 50};
            Assert.Equal(a, edabit.Method3(b));
            int[] c = {-99, 209};
            int[] d = {3, 54, -99, 209, 34, 75, -3, -45};
            Assert.Equal(c, edabit.Method3b(d));
        }

        [Fact]
        public void Test2()
        {
            Assert.True(edabit.Method2("aaaaa"));
            Assert.False(edabit.Method2b("aaabaaa"));
            Assert.False(edabit.Method2c("mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmn"));
            Assert.False(edabit.Method2c("nmmmmmmmmm"));
            Assert.True(edabit.Method2c("z"));
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal("April", edabit.Method1(4));
            Assert.Equal("November", edabit.Method1(11));
            Assert.Equal("December", edabit.Method1(12));
            Assert.Equal("Not on the Calendar", edabit.Method1(13));
        }
    }
}