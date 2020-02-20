using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Class1
    {

        private double radius;
        string st;

        public double Calculate(Func<double, double> mp)
        {
            return mp(radius);
        }
        public string Upper(Func<string,string> uc)
        {
            return uc(st);
        }
    }
}
