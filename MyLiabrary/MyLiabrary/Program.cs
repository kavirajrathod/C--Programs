using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Liabrary;

namespace MyLiabrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.EmpID = 123;
            e.Empname = "Kaviraj";
            e.EmpSalary = 12000;

            Console.WriteLine("Employee Id:{0}",e.show());
            Console.WriteLine(e.set());
            Console.WriteLine("Employee Salary:{0}",e.display());

            Employee e1 = new Employee();
            e1.EmpID = 568;
            e1.Empname = "Rathod";
            e1.EmpSalary = 50000;

            Console.WriteLine("\nEmployee Id:{0}", e1.show());
            Console.WriteLine(e1.set());
            Console.WriteLine("Employee Salary:{0}", e1.display());
            Console.ReadKey();
        }
    }
}
