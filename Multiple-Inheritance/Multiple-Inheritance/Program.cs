using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 c=new Class1();
            c.display("MH-24-AB-5382","YAMAHA","R15");
            c.show(2);
            c.showdata(10,20);
            c.set();

            Console.ReadKey();
        }
    }
}
