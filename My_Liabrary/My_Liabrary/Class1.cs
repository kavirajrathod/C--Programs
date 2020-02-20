using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Liabrary
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string Empname { get; set; }
        public double EmpSalary { get; set; }

        public int show()
        {
            return EmpID;
        }

        public string set()
        {
            return string.Format("Employee Name:{0}", Empname);
        }

        public double display()
        {
            return EmpSalary;
        }
    }
}
