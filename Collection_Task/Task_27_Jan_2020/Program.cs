using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_27_Jan_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Emp_Collection ec = new Emp_Collection();   
            int ab=0;
            do
            {
                Console.WriteLine("Enter choice:\n 1.Add Employee\n 2.Show Employee Details\n 3.Delete Employee\n 4.Exit");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        ec.get();
                        break;
                    case 2:
                        ec.show();
                        break;
                    case 3:
                        Console.WriteLine("Enter Index to Remove Element");
                        ec.delete(int.Parse(Console.ReadLine()));                       
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.WriteLine("press 1 to continue:");
                ab = int.Parse(Console.ReadLine());


            } while (ab==1);
 
            Console.ReadKey();
        }
    }
}
