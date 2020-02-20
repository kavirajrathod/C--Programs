using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLass_Liabaries;

namespace CLass_Lib
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculation c = new Calculation();
            c.num1 = 20;
            c.num2 = 5;
            Console.WriteLine(c.add());
            Console.WriteLine(c.difference());
            Console.WriteLine(c.multiply());
            Console.WriteLine(c.division());
            Console.ReadKey();
        }
    }
}
