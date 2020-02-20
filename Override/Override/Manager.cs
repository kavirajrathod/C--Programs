using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    class Manager:Emp
    {

        public override void Put()
        {
           
               Console.WriteLine("Derived class :Manager");
          
        }

    }
}
