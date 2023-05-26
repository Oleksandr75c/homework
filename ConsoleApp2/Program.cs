namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, res;
            double d;

            Console.WriteLine("Hello, enter plise number A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, enter plise number B");
            b = Convert.ToInt32(Console.ReadLine());

            res = a + b;
            Console.WriteLine("Result of sum  A and B: " + res);

            d = (double)a / (double)b;
            Console.WriteLine("Result of diving  A to B: " + d);

            Console.WriteLine("\nResult of -1 + 4 * 6 = " + (-1 + 4 * 6));
            Console.WriteLine("Result of ( 35+ 5 ) % 7 = " + ((35 + 5) % 7));
            Console.WriteLine("Result of 14 + -4 * 6 / 11 = " + (14 + -4 * 6 / 11));
            Console.WriteLine("Result of diving  2 + 15 / 6 * 1 - 7 % 2 = " + (2 + 15 / 6 * 1 - 7 % 2));

            // swap part
            Console.WriteLine("\nEnter to number for swap");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You Enter A = "+ a + " and B = " + b);
            c = a;
            a = b;
            b = c; 
            Console.WriteLine("After swap A = " + a + " and B = " + b);

            //multiplication
            Console.WriteLine("\nEnter plise number three number for multiplication");
            Console.WriteLine("Input the first number to multiply");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result of multiplacation is: " + (a*b*c));

        }
    }
}