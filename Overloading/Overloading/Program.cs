using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            sample s = new sample();
            sample s1 = new sample();
            sample s2 = new sample();
            sample s3 = new sample();
            sample.show();
            //   Sales s = new Sales("Kolhapuri-Bhadang",5 ,40);
            //   Sales s1 = new Sales("Laadu", 2, 40);
            //   s.show();
            //   s1.show();
            //  s1.display();





            //   Calculate c = new Calculate();
            //   Console.WriteLine(c.area(2));
            //   Console.WriteLine(c.area(5,6));
            //   Console.WriteLine(c.area(4.5));
            //   Console.WriteLine(c.area(12.4,8));

            Console.ReadKey();
        }
    }
}
