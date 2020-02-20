using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            Emp e = new Emp();
            e.Put();
            m.Put();
            Console.ReadKey();
        }
    }
}
