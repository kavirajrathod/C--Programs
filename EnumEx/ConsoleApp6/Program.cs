using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        enum Department
        {
            Physics = 10,
            Chemistry,
            Mathmatics = 20,
            History

        }
        enum Color { Red,Blue = 10,Green}
        enum Days
        {

            Sunday = 1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Department Enum");
            Console.WriteLine((int)Department.History);
            Console.WriteLine((int)Department.Mathmatics);
            Console.WriteLine((int)Department.Chemistry);

            Console.WriteLine("Color Enum");
            Console.WriteLine((int)Color.Red);
            Console.WriteLine((int)Color.Blue);
            Console.WriteLine((int)Color.Green);

            Console.WriteLine("Days Enum");
            Console.WriteLine("Last Working Day : "+Days.Friday+" "+(int)Days.Friday);
            Console.ReadLine();

        }
    }
}
