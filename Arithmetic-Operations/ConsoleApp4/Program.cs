using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=10, b=20;
            Console.WriteLine("Enter 1st Number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication of {0} and {1} = {2 }",a,b,Multiply(a, b));
            Console.WriteLine("Addition of {0} and {1} = {2 }", a, b, Add(a, b));
            Console.ReadLine();

        }

        public static double Multiply(int a, int b)
        {
            return (a*b);
        }

        public static double Add(int a, int b)
        {
            return (a+b);
        }
    }
}
