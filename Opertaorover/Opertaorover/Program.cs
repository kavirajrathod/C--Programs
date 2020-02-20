using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opertaorover
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo dd = new Demo(30,50);
            dd.show();
            Demo ddd = new Demo(10,5);
            ddd.show();


            Demo dd1 = new Demo();
            Console.WriteLine("\nAddition:");
            dd1 = dd + ddd;
            dd1.show();

            //  Demo dd2 = new Demo();
            Console.WriteLine("\nSubstraction:");
            dd1 = dd - ddd;
            dd1.show();

            //  Demo dd3 = new Demo();
            Console.WriteLine("\nMultiplication:");
            dd1 = dd * ddd;
            dd1.show();

            //  Demo dd4 = new Demo();
            Console.WriteLine("\nDivison:");
            dd1 = dd / ddd;
            dd1.show();
            Console.ReadKey();
        }
    }
}
