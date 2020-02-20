using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.get(10,"Kaviraj");
            Class2 c1 = new Class2();
            c1.get(20, "Rathod");
            Console.ReadKey();
        }
    }
}
