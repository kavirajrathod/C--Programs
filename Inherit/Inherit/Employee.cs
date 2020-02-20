using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Employee
    {
        int id;
        string name, address;
        Dept dp;

        public Employee(int id,string name,string address,Dept dp)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.dp = dp;
        }

        public void show()
        {
            Console.WriteLine("Id:{0}\n Name:{1}\n Address:{2}\n Dp:{3}", id, name, address,dp.showdata());
        }
    }
}