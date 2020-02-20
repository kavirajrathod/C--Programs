using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string ename;
            Console.WriteLine("Enter Name:");
            ename = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Congractulations Mr/Miss {0} on your {1} Birthday..!", ename, age);
            Console.Read();

        }
    }
}
