using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
           d.ShowVehicle();
            d.showdata();
            Dderived i = new Dderived();
            i.ShowVehicle();
            i.showdata();
            i.showdata();
            Console.ReadKey();
        }
    }
}
