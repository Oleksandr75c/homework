using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lCity = new List<string> { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            List<string> lfood = new List<string> { "Butter", "Honey", "Brade", "Biscuit" };
            string[] arr1 = new string[3] { "Welcome", "to", "https://classroom.google" };


            var lresult=lCity.OrderBy(x => x).OrderBy(x => x.Length);
            foreach(var ele in lresult) Console.WriteLine(ele);

            Console.WriteLine("\n");
            lresult = lfood.OrderBy(x => x);
            foreach (var ele in lresult)  Console.WriteLine(ele);

            Console.WriteLine("\nEnter minimum length of the item");
            int minl = Convert.ToInt32(Console.ReadLine());
            var lresult1 = arr1.Where(x => x.Length > minl).Select(x => x);
            foreach (var ele in lresult1) Console.WriteLine(ele);


        }
    }
}