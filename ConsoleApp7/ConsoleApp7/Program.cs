using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    partial class C
    {
        public int sum(int a,int b)
        {
            return (a+b);
        }
    }

    partial class C
    {
        public int mul(int a, int b)
        {
            return (a * b);
        }
    }
    namespace Demo
    {
        class C
        {
            public int sum(int a, int b)
            {
                return (a + b);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            Demo.C dc = new Demo.C();
            Console.WriteLine("Addition  = "+c.sum(10,20));
            Console.WriteLine("Multiplication  = "+c.mul(10,20));
            Console.WriteLine("Demo.Sum  = " + dc.sum(10, 20));
            Console.ReadLine();

        }
    }
}
