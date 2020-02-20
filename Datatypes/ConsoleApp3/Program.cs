using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 255;
            short s = 359;
            int n = 999;
            uint m = 99999;
            int k = -1234;
            long l = 10398959;
            ulong ul = 51263488;
            float f = 3.14f;
            double d = 3.14;
            decimal dc = 1095689123456;

            Console.WriteLine("Byte b = "+b);
            Console.WriteLine("Short s = " + s);
            Console.WriteLine("Int n = " + n);
            Console.WriteLine("Unsigned Int m  = " + m);
            Console.WriteLine("Long l = " + l);
            Console.WriteLine("Unsigned Long ul = " + ul);
            Console.WriteLine("Float f = " + f);
            Console.WriteLine("Double d = " + d);
            Console.WriteLine("Decimal dc = " + dc);

            DateTime dt = DateTime.Now;
            Console.WriteLine("Short Date : " + dt.ToShortDateString()+ "\nLong Date : " + dt.ToLongDateString());
            Console.ReadLine();


        }
    }
}
