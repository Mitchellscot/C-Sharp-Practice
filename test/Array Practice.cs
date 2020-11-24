using System;
using Xunit;

namespace w3resource
{
    public class ArrayPractice
    {
         [Fact]
        public void Test5() //count a total number of duplicate elements in an array
        {
            // answer given didn't work... i'm not sure this is possible
            
        }
         [Fact]
        public void Test4() // copy the elements one array into another array.
        {
            int[] a = { 1, 2, 3};
            int[] b = new int[a.Length];

            foreach (var n in a)
            {
                b = a;
            }
            Assert.Equal(a, b);
        }
        [Fact]
        public void Test3() //find the sum of all elements of the array
        {
            int[] a = { 1, 2, 3};
            int sum = 0;
            foreach (var n in a)
            {
                sum = sum +n;
            }
            Assert.Equal(6, sum);
        }
       // [Fact]
       /* public void Test2() //read n number of values in an array and display it in reverse order
        {
            
            System.Console.WriteLine("Input the number of elements to store in the Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ia = new int[n];
            for (int i = 0; i < ia.Length; i++)
            {
                System.Console.WriteLine($"Please enter number {i+1}");
                ia[i] = Convert.ToInt32(Console.ReadLine());
            }
            System.Console.Write($"The values you entered were: ");
            foreach (var i in ia)
            {
                Console.Write($"{i} ");
            }
            System.Console.Write($"\nAnd in reverse order they are: ");
            Array.Reverse(ia);
            foreach (var i in ia)
            {
                Console.Write($"{i} ");
            }
            Console.ReadLine();
            
        }*/
        [Fact]
        public void Test1() //store elements in an array and print it.. or just copy it to another array.
        {
            int[] ia = {1,2,3,4,5,6,7,8,9,10};
            int[] ans = new int[ia.Length];
            Console.Write("Elements in the array are: ");
            for (int i = 0; i < ia.Length; i++)
            {
                ans[i] = ia[i]; 
            }
            Assert.Equal(ia, ans);
            /*
            int[] ia = new int[10];
            for (int i = 0; i <= ia.Length-1; i++)
            {
                System.Console.WriteLine($"Please enter number {i+1}");
                ia[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Elements in the array are: ");
            for (int i = 0; i <= ia.Length-1; i++)
            {
                Console.Write($"{ia[i]}-");
            }
            Console.ReadLine();
            */
        }
    }
}
