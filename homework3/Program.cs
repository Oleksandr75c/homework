namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;


            //Write a C# program to check two given integers and return true if one is negative and one is positive.
            Console.WriteLine("Check number for sign:");
            Console.WriteLine("Input the first number A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number B");
            b = Convert.ToInt32(Console.ReadLine());

            if (((a > 0) && (b < 0)) || ((a < 0) && (b > 0))) Console.WriteLine("One number is negative, another is positive");
            else  Console.WriteLine("The both numbers have the same sign");

            //Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
            Console.WriteLine("\nCheck sun or number for 20:");
            Console.WriteLine("Input the first number A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number B");
            b = Convert.ToInt32(Console.ReadLine());

            if ((a == 20) || (b == 20) || ((a + b) == 20)) Console.WriteLine("A or B or their sum are 20");

            //Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
            Console.WriteLine("\nPrint the odd numbers from 1 to 99");
            for (int i = 1; i < 100; i++) 
                if (i%2 != 0) Console.WriteLine(i);

            //Write a C# program to compute the sum of the first 500 prime 
            // algoritm to get primre number:
            //  ru.wikipedia.org/wiki/Перебор_делителей

            a = 2; //all numbers; 2-first prime number
            sum = 0;
            for (int i=1;i<=500;)    // i - count prime number
            {
                b = 1;  // 1 - prime number, 0 - not prime
                for (int j=2;j <= Convert.ToInt32(Math.Sqrt(a)); j++)
                { if ((a%j)==0) // not prime number
                    { b = 0; break; }
                }
                sum += b*a;
                if(b==1) Console.WriteLine($"number {a} is a prime #{i}; sum= {sum}");
                a++;
                i += b;
            }
            Console.WriteLine($"\nSumm 500 prime numbers is {sum}");
        }
    }
}