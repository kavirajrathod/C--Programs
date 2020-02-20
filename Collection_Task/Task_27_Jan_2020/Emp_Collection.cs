using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_27_Jan_2020
{
    class Emp_Collection
    {
        List<Employee> lstEmployee = new List<Employee>();


        public void get()
        {
            Employee e = new Employee();
            Console.WriteLine("Enter Employee ID");
            e.Eid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            e.Emp_name = Console.ReadLine();
            Console.WriteLine("Enter Employee Designation");
            e.Designation = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            e.Salary = double.Parse(Console.ReadLine());

            lstEmployee.Add(e);
        }

        public void show()
        {

            foreach (Employee em in lstEmployee)
            {
                Console.WriteLine("{0}  {1}  {2}  {3}", em.Eid, em.Emp_name, em.Designation, em.Salary);
            }
        }

        public void delete(int index)
        {
            lstEmployee.RemoveAt(index);
        }

    }
}
