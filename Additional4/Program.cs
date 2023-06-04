using System.ComponentModel;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b,c, max;
            int[] arr1 = { 2, 9, 1, 4, 6, 1, 6, -9, 7 };
            string str1="";
            byte[] arr2 = { 0x18, 0x3C, 0x66, 0xC3, 0xFF, 0xC3, 0xC3 };     // bit image of character A


            Console.WriteLine("Enter please a big integer number:");
            a = Convert.ToInt32(Console.ReadLine());                    
            Console.WriteLine($"Reverse number is {ReverseNumber(a)}\n");

            //Write a C# Sharp program to display an alphabet pattern like A with an asterisk.Reversed string is:Display the pattern like 'A' with an asterisk:
            for (int i = 0; i < arr2.Length; i++)
                ConvertByteToLine(arr2[i]);

            //Write a C# Sharp program to find the second largest element in an array.
            for (int i = 0; i < arr1.Length; i++)   str1 += (arr1[i] + ", ");
            Console.WriteLine($"\nArray:{str1}");
            max = FindMaxNumber(arr1);
            Console.WriteLine($"The largest element in the array is:{max}");
            Console.WriteLine($"The Second largest element in the array is:{FindSecondMaxNumber(arr1,max)}");

            // Write a C# Sharp program to check whether a triangle can be formed by the given angles value.
            Console.WriteLine("\nEnter please 3 angles separated by a space:");
            if (CheckTriangleAngles(Console.ReadLine())) Console.WriteLine("The triangle is valid");
            else Console.WriteLine("The triangle is not valid");

        }

        //Write a program in C# Sharp to display a number in reverse order.
        public static int ReverseNumber(int a)
        {
            string s = a.ToString();
            string res="";
            for(int i = s.Length -1; i>=0; i--)
            {
                res += s[i];
            }
            return Convert.ToInt32(res);
        }

        // find the largest value from array
        public static int FindMaxNumber(int[] arr)
        {
            int max = arr[0];
            for (int i=1; i<arr.Length; i++)
                if (max < arr[i]) max = arr[i];
            return max;
        }

        //Write a C# Sharp program to find the second largest element in an array.
        public static int FindSecondMaxNumber(int[] arr, int max)
        {
            int max2 = arr[0];
            for (int i = 0; i < arr.Length; i++)
                if ((max2 < arr[i]) && (arr[i] < max)) max2 = arr[i];
            return max2;
        }

        //convert bit image to string
        public static void ConvertByteToLine(byte a)
        { string str="";
            for (int i = 1; i < 512; i *= 2)
                if ((a & i) == 0) str += " ";
                else str += "*";
            Console.WriteLine(str);
        }

        // Write a C# method to find the lowest value from three integer values.
        public static bool CheckTriangleAngles(string str)
        {
            string[] arrs = new string[3];
            int sum = 0;
            arrs = str.Split(' ');
            for (int i = 0; i < 3; i++) sum += Convert.ToInt32(arrs[i]);
            if (sum == 180) return true;
            return false;
        }
    }
}