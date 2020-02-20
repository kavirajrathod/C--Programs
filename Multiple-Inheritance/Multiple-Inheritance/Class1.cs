using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance
{
    class Class1:Bike,BikeInter
    {
        public void show(int i)
        {
            for (i = 0; i<10; i++)
            {
                Console.WriteLine("In Show Method{0}",i);
            }
           
        }

        public void showdata(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("In ShowData Method Addition: {0}",c);
        }

        public void set()
        {
            Console.WriteLine("In Set Method");
        }
    }
}
