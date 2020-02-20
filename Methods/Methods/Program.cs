using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Lambda();
            Console.ReadKey();

        }

        private static void Lambda()
        {
            Func<int, int> cuba = a => a * a * a;
            Console.WriteLine("Enter number:");
            int cr = int.Parse(Console.ReadLine());
            Console.WriteLine(cuba(cr));

            Func<int, double,double> div = (x,y) => x*y;
            Console.WriteLine("Enter number:");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number:");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine(div(d,v));
        }
    }
}
