using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Derived : Base
    {
        public void show()
        {
            Console.WriteLine("In Intermediate Class");
        }

        public override void show()
        {
            Console.WriteLine("In overridden Intermediate Class");
        }
    }
}
