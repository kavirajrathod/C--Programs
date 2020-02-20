using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            Console.WriteLine("Enter number");
            double p= int.Parse(Console.ReadLine());

            Console.WriteLine(c.Calculate(r=> 2 * Math.PI * p ));
            Console.WriteLine();
            Console.WriteLine(c.Calculate(r => Math.PI * p * p));
            Console.WriteLine(c.Calculate(a => p*p* p));

            Console.WriteLine("Enter String:");
            string s = Console.ReadLine();
            Console.WriteLine(c.Upper(a => s.ToUpper()));

            Console.WriteLine(c.Upper(a => s.ToLower()));


            Console.ReadKey();
        }
    }
}
