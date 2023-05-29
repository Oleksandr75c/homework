using System.ComponentModel;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {int a, b, c;
            int[] arr1 = { 1, 2, 3, 4, -4, -6, 1 };


            Console.WriteLine("Enter please 3 numbers for find max and min value:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Max number is {FindMaxNumber(a, b, c)}");
            Console.WriteLine($"Min number is {FindMinNumber(a, b, c)}");

            Console.WriteLine("\nEnter please 3 numbers for find nearest value of 20:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = FindMNearest20Number(a, b);
            if (c == 0) Console.WriteLine("The both number nearest on the same distanse");
            else Console.WriteLine($"Nearest value 0f 20 is {c}");

            Console.WriteLine($"\nSumm array is {SumArray(arr1)}");

            Console.WriteLine($"\nMax number in array is {FindMaxArray(arr1)}");

        }

         // Write a C# method to find the largest value from three integer values.
        public static int FindMaxNumber (int a, int b, int c)
            { 
                if (a > b &&  a > c) return a;  
                else if (b > c) return b;
                return c; 
            }

        // Write a C# method to find the lowest value from three integer values.
        public static int FindMinNumber(int a, int b, int c)
            {
                if (a < b && a < c) return a;
                else if (b < c) return b;
                return c;
            }

        //Write a C# method to check the nearest value of 20 of two given integers and return 0 if two numbers are same 
        public static int FindMNearest20Number(int a, int b)
        {
            if (Math.Abs(a - 20) > Math.Abs(b - 20)) return b;
            if (Math.Abs(a - 20) == Math.Abs(b - 20)) return 0;
            return a;
        }

        //Write a C# method to compute the sum of all the elements of an array of integers
        public static int SumArray(int[] a)
        {
            int sum=0;
            for (int i=0; i < a.Length; i++)  sum += a[i];
            return sum;
        }

        //Write a C# method to get the larger value from array
        public static int FindMaxArray(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (a[i] > max) max = a[i];
            return max;
        }
    }
}