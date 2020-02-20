using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "Damodar";
            string lname = "Khedkar";
            string full_name = fname + lname;

            Console.WriteLine("Length of fname = "+fname.Length);
            Console.WriteLine("Length of lname = " + lname.Length);
            Console.WriteLine("Length of full_name = " + full_name.Length);
            Console.WriteLine( full_name.ToUpper());
            Console.WriteLine(full_name.ToLower());
            Console.WriteLine( full_name[5]);
            Console.ReadLine();

        }
    }
}
