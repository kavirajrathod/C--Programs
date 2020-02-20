using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ananym
{
    class Program
    {
        public delegate void Mydelg(string s);
        static void Main(string[] args)
        {
            Mydelg d = a => Console.WriteLine(a);
            d("Hii Kavi");

            Func<int, double,Double> area = (l,b) => 0.5*l*b;
            Console.WriteLine(area(2,3));
            Console.ReadKey();
        }
    }
}
