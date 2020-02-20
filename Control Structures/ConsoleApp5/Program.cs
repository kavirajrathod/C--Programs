using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            

            do
            {
                Console.WriteLine("Enter a number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a number");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Select Operation");
                Console.WriteLine("1.Add\n2.Sub\n3.Mul\n4.Div\n");
                int op = int.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1 :
                        Console.WriteLine("Addition of {0} and {1} = {2}",a,b,(a+b));
                        break;
                    case 2:
                        Console.WriteLine("Subtraction of {0} and {1} = {2}", a, b, (a - b));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication of {0} and {1} = {2}", a, b, (a * b));
                        break;
                    case 4:
                        Console.WriteLine("Division of {0} and {1} = {2}", a, b, (a / b));
                        break;
                    default:
                        Console.WriteLine("Incorrect Choice...!");
                        break;
                }
                Console.WriteLine("Do you wants to continue Press 1 ");
                choice = int.Parse(Console.ReadLine());
            } while (choice==1);


        }
    }
}
