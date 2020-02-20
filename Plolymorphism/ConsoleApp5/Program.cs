using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{

    class Operation
    {
        public double Mult(int a,int b)
        {
            return 0;
        }
    }
    class B : Operation
    {
        public double Mult(int a, int b)
        {
            return a * b;

        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            Operation o = new Operation();
            B b = new B();
            Console.WriteLine("Enter 1st number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Operation Class Method called :="+o.Mult(n1,n2));
            Console.WriteLine("B Class Method called :=" + b.Mult(n1, n2));
            Console.ReadLine();
        }
    }
}
