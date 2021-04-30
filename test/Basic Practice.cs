using System;
using Xunit;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace w3resource
{
    public class BasicPractice
    {
        /* [Fact]  
        public void Test()
        {
            // arrange
            //int a = ;
            // act

            // assert
            //Assert.Equal();
        } */
        [Fact]  
         public void Test63() //capitalize every word in a sentance
        {
            // arrange
            string phrase = "mitchell sarah henry lydia edward arthur";
            // act
            string[] words = phrase.Split(" ");
            int pos = 0;
            foreach (var word in words)
            {
                char[] w = word.ToCharArray();
                w[0] = Char.ToUpper(w[0]);
                words[pos] = new string(w);
                pos++;
            }
            string result =  string.Join(" ", words);
            // assert
            Assert.Equal("Mitchell Sarah Henry Lydia Edward Arthur", result);
        }
        [Fact]   
        public void Test62() //Create a function (or write a script in Shell) that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
        {
            // arrange
            int a = 8;
            string answer = "";
            // act
/*             if (a % 2 == 0){
                answer = "even";
            }
            else {
                answer = "odd";
            } */
            answer = a % 2 == 0 ? "even" : "odd";
            // assert
            Assert.Equal("even", answer);
        }
        [Fact]  
        public void Test61() // Create a function that computes the hamming distance between two strings (number of different characters)
        {
            string mitch = "mitchell";
            string mitch2 = "Mi5fhelz";
/*             string sarah = "sarah";
            string sarah2 = "Saraz"; */
            int ham = 0;
            // arrange
            for (int i = 0; i < mitch.Length; i++)
            {
                if (mitch[i] != mitch2[i]){
                    ham++;
                }
            }
            // act

            // assert
            Assert.Equal(4, ham);
        } 
        [Fact]  
        public void Test60() //Create a function that takes a number n and returns its length.
        {
            //arrange
            int n = 300;
            var str = n.ToString();
            //act
            var number = str.Length;
            //assert
            Assert.Equal(3, number);
        }
        [Fact]  
        public void Test58() //accept a list of integers and checks how many integers are needed to complete the range
        {
            // arrange
            int[] a = {0,1,2,3,4,5,6,7,8,9,100};
            // act
            int an = Math.Abs(a.Length - a[a.Length-1]); 
            // assert
            
            Assert.Equal(89, an);
        }
        [Fact]  
        public void Test57() //find the pair of adjacent elements that has the highest product of an given array of integers
        {
            // arrange
            int[] a = {1,2,3,4,5,6,7,8,9,1,2,3,4,5};
            int m = 0;
            int p1 = 0;
            int p2 = 0;
            // act
            for (int i = 0; i < a.Length-1; i++)
            {
                if (a[i]*a[i+1] > m)
                {
                    m = a[i]*a[i+1];
                    p1 = a[i];
                    p2 = a[i+1];
                }
            }
            // assert
            Assert.Equal(72, m);
        }
        [Fact]  
        public void Test56() // check if a given string is a palindrome or not
        {
            // arrange
            string p = "racecar";
            string r = String.Empty;
            bool b = false;
            // act
            for (int i = p.Length -1; i >= 0; i--)
            {
               r += p[i]; 
            }
            if (p==r)
            {
                b = true;
            }
            // assert
            Assert.True(b);
        }
        [Fact]  
        public void Test54() // get the century from a year
        {
            // arrange
            int a = 1984;
            // act

            // assert
            Assert.Equal(20, a/100+1);
        }
        [Fact]  
        public void Test53() //check if an array contains an odd number
        {
            // arrange
            int[] a = {3, 4, 6, 8, 10};
            bool b = false;
            // act
            foreach (var n in a)
            {
                if (n % 2 != 0)
                {
                    b=true;
                } 
            }
            // assert
            Assert.True(b);
        }
        [Fact]
        public void Test52() //create a new array of length containing the middle elements of three arrays (each length 3) of integers
        {
            int[] a = {5,6,2};
            int[] b = {7,0,7};
            int[] c = {2,1,8};
            
            int[] d = {a[1], b[1], c[1]};

            int[] e = {6,0,1};
            Assert.Equal(e,d);

        }
        [Fact]
        public void Test51() //get the larger value between first and last element of an array (length 3) of integers
        {
            int[] a = {20,3,4,5,6,7,8,900,10,1,9,90,100, 200,2,3,5};
            int b = 0;
            foreach (var i in a)
            {
                if (i>b)
                {
                    b=i;
                }
            }
            Assert.Equal(900, b);
        }
        [Fact]
        public void Test50() // rotate an array (length 3) of integers in left direction
        {
            int[] a = {1,2,3,4,5,6,7,8,9,10};
            int[] b = {2,3,4,5,6,7,8,9,10,1};
            int temp =a[0];
            for (int i = 0; i < a.Length-1; i++)
            {
             a[i] = a[i+1];
            }
            a[a.Length-1] = temp; 
            Assert.Equal(b, a);
        }
        [Fact]
        public void Test49() //check if the first element or the last element of the two arrays (length 1 or more) are equal.
        {
            int[] a = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] b = { 5, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            bool c = false;
            if (a.Length > 1)
            { c = (a[0] == b[0] || a[a.GetUpperBound(0)] == b[b.GetUpperBound(0)]) ? true : false; }
            Assert.True(c);
        }
        [Fact]
        public void Test48() //check if the first element and the last element are equal of an array of integers and the length is 1 or more
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            bool b = false;
            if (a.Length > 1)
            { b = (a[0] == a[a.GetUpperBound(0)]) ? true : false; }
            Assert.True(b);
        }
        [Fact]
        public void Test47() // compute the sum of all the elements of an array of integers
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int b = 0;
            foreach (var i in a)
            {
                b += i;
            }
            Assert.Equal(55, b);

        }
        [Fact]
        public void Test46() //check if a number appears as either the first or last element of an array of integers and the length is 1 or more
        {
            int[] ia = { 12, 5, 1 };
            int c = 1;
            bool b = false;
            if (ia.Length > 1)
            { b = (ia[0] == c || ia[ia.Length - 1] == c) ? true : false; }
            Assert.True(b);
        }
        [Fact]
        public void Test45() //count a specified number in a given array of integers
        {
            int[] ia = { 5, 4, 5, 6, 7, 8, 5, 4, 3, 5, 6, 7, 8, 5, 4, 5, 8 };
            int count = 0;
            foreach (var e in ia)
                if (e == 5)
                {
                    count++;
                }
            Assert.Equal(6, count);
        }
        [Fact]
        public void Test44() // create a new string of every other character (odd position) from the first position of a given string
        {
            string s = "Mitchell";
            string a = String.Empty; // here it is used like a char[]
            for (int i = 0; i < s.Length; i += 2)
            {
                a += s[i]; // this works, assignment = doesn't work.

            }
            Assert.Equal("Mthl", a);
        }
        [Fact]
        public void Test43() //check if a given string starts with "w" and immediately followed by two "ww".
        {
            string s = "www.Mitchell.Com";
            bool b = false;
            if (s[0] == 'w' || s[0] == 'W')
            {
                if (s[1] == 'w' && s[2] == 'w' || s[1] == 'W' && s[2] == 'W')
                {
                    b = true;
                }
                else b = false;
            }
            else
            {
                b = false;
            }
            Assert.True(b);
        }
        [Fact]
        public void Test42() //create a new string where the first 4 characters will be in lower case. If the string is less than 4 characters then make the whole string in upper case.
        {
            string s = "MITCHELL";
            string a = (s.Length > 4) ? s.Substring(0, 4).ToLower() + s.Substring(4, s.Length - 4) : s.ToUpper();
            Assert.Equal("mitcHELL", a);
        }
        [Fact]
        public void Test41() //check if a given string contains ‘w’ character between 1 and 3 times
        {
            string str = "www3resource";
            bool b = false;
            int count = 0;
            foreach (var c in str)
            {
                if (c == 'w')
                    count++;
            }
            if (count > 0 && count < 4)
            { b = true; }
            Assert.True(b);
        }
        [Fact]
        public void Test40() //check the nearest value of 20 of two given integers and return 0 if two numbers are same
        {
            int a = 15;
            int b = 12;
            int c = CheckNum(a, b);
            Assert.Equal(15, c);

        }
        private int CheckNum(int a, int b)
        {
            if (a == b)
                return 0;
            else if (Math.Abs(a - 20) < Math.Abs(b - 20))
                return a;
            else return b;
        }
        [Fact]
        public void Test39() //find the largest and lowest values from three integer values
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int ans1 = a.Min();
            int ans2 = a.Max();
            Assert.Equal(1, ans1);
            Assert.Equal(20, ans2);
        }
        [Fact]
        public void Test38() // get a new string of two characters from a given string. The first and second character of the given string must be "P" and "H", so PHP will be "PH".
        {
            string str = "PHP Tutorial";
            string answer = str[0].ToString() + str[1].ToString();
            Assert.Equal("PH", answer);

        }
        [Fact]
        public void Test37() //check if "HP" appears at second position in a string and returns the string without "HP"
        {
            string php = "PHP tutorial";
            string answer = "";
            if (php[1] == 'H' && php[2] == 'P')
            { answer = php.Remove(1, 2); }
            Assert.Equal("P tutorial", answer);
        }
        [Fact]
        public void Test36() //check if an integer (from the two given integers) is in the range -10 to 10
        {
            int a = 6;
            int b = -9;
            bool c = (a >= -10 && a <= 10 && b >= -10 && b <= 10) ? true : false;
            Assert.True(c);
        }
        [Fact]
        public void Test35() // check two given numbers where one is less than 100 and other is greater than 200
        {
            int a = 75;
            int b = 210;
            bool c = (a < 100 && b > 200) ? true : false;
            Assert.True(c);
        }
        [Fact]
        public void Test34() // check if a string starts with a specified word
        {
            string word = "hello";
            string sent = "hello how are you";
            bool b = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == sent[i])
                    continue;
                else b = false;
                break;
            }
            Assert.True(b);
        }
        [Fact]
        public void Test33() //check if a given positive number is a multiple of 3 or a multiple of 7
        {
            int n = 9;
            bool b = true;
            if (n % 3 == 0 || n % 7 == 0)
                b = true;
            else
                b = false;
            Assert.True(b);
        }
        [Fact]
        public void Test32() //create a new string of four copies, taking last four characters from a given string. If the length of the given string is less than 4 return the original one
        {
   
            // arrange
            string  s = "I think my wife will give birth today";
            char[] arr = s.ToCharArray();
            string answer = "";
            // act
            if (arr.Length < 4)
                Console.WriteLine("not enough characters in string");
            else
            {
                string print = String.Join("", arr[arr.Length-4], arr[arr.Length-3], arr[arr.Length-2], arr[arr.Length-1]);
                answer = print+print+print+print;
            }
            // assert
           Assert.Equal("odayodayodayoday", answer);
        }
        [Fact]
        public void Test31() //multiply corresponding elements of two arrays of integers
        {
            // arrange
            int[] Array1 = new int[] { 1, 3, -5, 4 };
            int[] Array2 = new int[] { 1, 4, -5, -2 };
            int[] answer = new int[Array1.Length];
            // act
            for (int i = 0; i < Array1.Length; i++)
            {
                answer[i] = Array1[i] * Array2[i];

            }
            // assert
            int[] answers = new int[] { 1, 12, 25, -8 };
            Assert.Equal(answers, answer);
        }
        [Fact]
        public void Test30() // convert a hexadecimal number to decimal number
        {
            // arrange
            int a = 1200;
            string hex = "4B0";
            // act
            int answer = Convert.ToInt32(hex, 16);
            // assert
            Assert.Equal(a, answer);
        }
/*         [Fact]
        public void Test29() // find the size of a specified file in bytes
        {
            // arrange
            string path = @"C:\Users\Mitch\Documents\Code\Practice\src\DummyDoc.txt";
            FileInfo fi = new FileInfo(path);
            // act
            int bytes = (int)fi.Length;
            // assert
            Assert.Equal(15, bytes);
        } */
        [Fact]
        public void Test28() //reverse the words of a sentance
        {
            // arrange
            // string s = "Mitchell Norman Scott";
            // act
            // assert
            // Assert.Equal("Scott Norman Mitchell", s.Split(" ").Reverse().Join(" "));


            /* // arrange
            string str = "Mitchell Norman Scott";
            string[] strArray = str.Split(' ');
            string[] reversed = new string[strArray.Length];
            int index = 0;
            //  act
            for (int i = strArray.GetUpperBound(0); i >= 0; i--)
            {
                reversed[index] = strArray[i];
                index++;
            }
            string answer = String.Join(" ", reversed);
            // assert
            Assert.Equal("Scott Norman Mitchell", answer); */
        }
        [Fact]
        public void Test27() // compute the sum of the digits of an integer
        {
            // arrange
            int n = 245678;
            string str = n.ToString();
            char[] cArr = str.ToCharArray();
            double sum = 0;
            // act
            for (int i = 0; i < cArr.Length; i++)
            {
                sum = sum + (char.GetNumericValue(cArr[i]));
            }
            // assert
            Assert.Equal(32, sum);
        }
        // [Fact]  
        // public void Test26() // compute the sum of the first 500 prime numbers. I did not get this one right.
        // {
        // }
        /*[Fact]
        public void Test25() //print the odd numbers from 1 to 99. Prints one number per line
        {
            for (int i = 1; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine(); */
        // }
        [Fact]
        public void Test24() // find the longest word in a string
        {
            // arrange
            string str = "Sarah Henry Lydia Edward Aruthur Mitchell Scott";
            string[] stArray = str.Split(' ');
            int index = 0;
            int biggestLength = 0;
            // act
            foreach (string s in stArray)
            {
                if (s.Length > biggestLength)
                {
                    biggestLength = s.Length;
                    stArray.SetValue(s, index);
                }
            }
            // assert
            Assert.Equal("Mitchell", stArray[index]);
        }
        [Fact]
        public void Test23() //convert a given string into lowercase
        {
            // arrange
            string a = "MITCHELL";
            // act
            string lc = a.ToLower();
            // assert
            Assert.Equal("mitchell", lc);
        }
        [Fact]
        public void Test22() //check if an given integer is within 20 of 100 or 200
        {
            // arrange
            int a = 110;
            // act
            bool answer = (a >= 80 && a <= 120 || a >= 180 && a <= 220) ? true : false;
            // assert
            Assert.True(answer);
        }
        [Fact]
        public void Test21() //check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20
        {
            // arrange
            int a = 20;
            int b = 1;
            // act
            bool answer = (a + b == 20 || a == 20 || b == 20) ? true : false;
            // assert
            Assert.True(answer);
        }
        [Fact]
        public void Test20() //get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number.
        {
            // arrange
            int a = 40;
            int b = 13;
            int result = 0;
            // act
            if (a - b < 0)
            { result = (b - a); }
            else
            { result = (a - b) * 2; }
            // assert
            Assert.Equal(54, result);
        }
        [Fact]
        public void Test19() //compute the sum of two given integers, if two values are equal then return the triple of their sum
        {
            // arrange
            int a = 5;
            int b = 5;
            // act
            int result = (a == b) ? (a + b) * 3 : a + b;
            // assert
            Assert.Equal(30, result);
        }
        [Fact]
        public void Test18() //check two given integers and return true if one is negative and one is positive
        {
            // arrange
            int a = 5;
            int b = 5;
            // act
            bool result = (a < 0 && b > 0 || a > 0 && b < 0) ? true : false;
            // assert
            Assert.False(result);
        }
        [Fact]
        public void Test17() //create a new string from a given string with the first character added at the front and back
        {
            // arrange
            string str = "Scott";
            // act
            string answer = str.Substring(0, 1) + str + str.Substring(0, 1);
            // assert
            Assert.Equal("SScottS", answer);
        }
        [Fact]
        public void Test16() // create a new string from a given string where the first and last characters will change their positions
        {
            // arrange
            string str = "Mitchell";
            // act
            string answer = String.Format(str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1));
            // assert
            Assert.Equal("litchelM", answer);
        }
        [Fact]
        public void Test15() //remove specified a character from a non-empty string using index of a character
        {
            // arrange
            string a = "w3resource";
            int i = a.IndexOf("3");
            // act
            var b = a.Remove(i, 1);
            // assert
            Assert.Equal("wresource", b);

            /* System.Console.WriteLine("Please enter a string:");
            string str = Console.ReadLine();
            System.Console.WriteLine($"You entered the word: {str}\nPlease enter a char to remove: ");
            int i = str.IndexOf(Console.ReadLine());
            var answer = str.Remove(i,1);
            // act
            Console.WriteLine($"Here is the new word: {answer}"); */
        }
        [Fact]
        public void Test14() // convert from celsius degrees to Kelvin and Fahrenheit.
        {
            // arrange
            double celsius = 30;
            // act
            double kelvin = celsius + 273.15;
            double fahrenheit = (celsius * 1.8) + 32;
            // assert
            Assert.Equal(303.15, kelvin);
            Assert.Equal(86, fahrenheit);
        }
        // [Fact]  
        // public void Test13() //takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.
        //{
        // arrange
        // int a = 5;
        // act
        // Console.WriteLine($"{a}{a}{a}\n{a} {a}\n{a} {a}\n{a} {a}\n{a}{a}{a}");
        // assert
        // Assert.Equal();
        //}
        // [Fact]
        // public void Test12() //takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation.
        //{
        // arrange
        // int a = 25;
        // act
        // Console.Write($"{a} {a} {a} {a}\n{a}{a}{a}{a}\n{a} {a} {a} {a}\n{a}{a}{a}{a}");
        // assert
        // Assert.Equal();
        //} 
        [Fact]
        public void Test11() //takes an age (for example 20) as input and prints something as "You look older than 20"
        {
            // arrange
            int age = 20;
            // act
            string answer = ($"you look older than {age}");
            // assert
            Assert.Equal("you look older than 20", answer);
        }
        [Fact]
        public void Test10() //takes three numbers(x,y,z) as input and print the output of (x+y)*z and x*y + y*z
        {
            int x = 5;
            int y = 6;
            int z = 7;

            int a = (x + y) * z;
            int b = (x * y) + (y * z);

            Assert.Equal(77, a);
            Assert.Equal(72, b);

            /* const int HOW_MANY = 3;
           int i = 0;
           var arr = new int[HOW_MANY];
           while (i < HOW_MANY)
           {
             System.Console.WriteLine("Give me yo digitz: ");
             arr[i] = Convert.ToInt32(Console.ReadLine());
             i++;
           }
           int firstCalc = (arr[0]+arr[1])*arr[2];
           int secondCalc = (arr[0]*arr[1])+(arr[1]*arr[2]);
           Console.WriteLine($"Results of specific numbers {arr[0]}, {arr[1]} and {arr[2]}:\n(x+y)*z is {firstCalc}\nx*y+y*z is {secondCalc}"); */
        }
        [Fact]
        public void Test9() //that takes four numbers as input to calculate and print the average
        {
            int a = 10;
            int b = 15;
            int c = 20;
            int d = 30;
            var arr = new int[] { a, b, c, d };
            var avg = arr.Sum() / arr.Length;

            Assert.Equal(18, avg);
        }
        // [Fact]
        // public void Test8() // takes a number as input and print its multiplication table.
        // {
        /* System.Console.WriteLine("Please enter a number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{a}*0 = 0\n{a}*1 = {a}\n{a}*2={a * 2}\n{a}*3={a * 3}\n{a}*4={a * 4}\n{a}*5={a * 5}\n{a}*6={a * 6}\n{a}*7={a * 7}\n{a}*8={a * 8}\n{a}*9={a * 9}\n{a}*10={a * 10}\n"); */

        //a better way:

        /* Console.Write("Enter the number: ");
        int x = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 11; i++)
        {
            int result = x * i;
            Console.WriteLine($"{x} * {i} = {result}");
        } 

                                OR

        int i = 0;
        while (i <= 10)
        {
            Console.WriteLine("{0} * {1} = {2}", x, i, (x * i));
            i++;
        } 
        */
        // }
        [Fact]
        public void Test7() //print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user
        {
            int x = 25;
            int y = 4;
            int a = x + y;
            int b = x - y;
            int c = x * y;
            int d = x / y;
            int e = x % y;

            /* Console.WriteLine($"{x} + {y} = {a}\n{x} - {y} = {b}\n{x} * {y} = {c}\n{x} / {y} = {d}\n{x} mod {y} = {e}\n"); */

            Assert.Equal(29, a);
            Assert.Equal(21, b);
            Assert.Equal(100, c);
            Assert.Equal(6, d);
            Assert.Equal(1, e);
        }
        [Fact]
        public void Test6() // print the output of multiplication of 3 numbers
        {
            int a = 2;
            int b = 3;
            int c = 6;

/*             Console.WriteLine($"{a * b * c}");
 */
            Assert.Equal(36, a * b * c);
            /* static void Main(string[] args)
            {
            System.Console.WriteLine("Please enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Please enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Please enter the third number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Multiply(a,b,c);
            Console.WriteLine($"Here is the sum of those numbers multiplied: {d}");  
            }

            private static int Multiply(int a, int b, int c)
            {
            return a*b*c;

            } */
        }
        [Fact]
        public void Test5() // swap two numbers
        {
            int a = 5;
            int b = 6;
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
            Assert.Equal(6, a);
            Assert.Equal(5, b);
            /* System.Console.WriteLine("Please enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Please enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"First number is now {a} \nSecond number is now {b}");  */
        }
        [Fact]
        public void Test4()
        {
            int a = -1 + 4 * 6;
            int b = (35 + 5) % 7;
            int c = 14 + -4 * 6 / 11;
            int d = 2 + 15 / 6 * 1 - 7 % 2;

/*             Console.WriteLine($"{a}\n{b}\n{c}\n{d}");
 */
            Assert.Equal(43, a + b + c + d);
        }
        [Fact]
        public void Test3()
        {
            int a = 2;
            int b = 4;

/*             Console.WriteLine(b / a);
 */
            Assert.Equal(2, b / a);
        }
        [Fact]
        public void Test2()
        {
            int a = 2;
            int b = 4;

/*             Console.WriteLine(a + b);
 */
            Assert.Equal(6, a + b);
        }
        [Fact]
        public void Test1()
        {
            string name = "Hello Mitchell";
            Assert.Equal("Hello Mitchell", name);
        }

    }
}
