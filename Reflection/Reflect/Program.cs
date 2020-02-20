using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Reflect
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = typeof(int).Assembly;
            Console.WriteLine(asm);
            int x = 10;
            Type t = x.GetType();
            Console.WriteLine(t);
            Console.WriteLine(x.GetTypeCode());
           
            StringBuilder str = new StringBuilder("HEllO");
            Console.WriteLine(str.GetType());

            asm = typeof(string).Assembly;
            Console.WriteLine(asm);
            Console.ReadKey();

        }
    }
}
