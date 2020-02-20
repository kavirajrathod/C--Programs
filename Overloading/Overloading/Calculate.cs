using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Calculate
    {
        public string area(int side)
        {
            int arr = side * side;
            return string.Format("Sqaure area= {0}", arr);
        }

        public string area(int l,int b)
        {
            int ar = l * b;
            return string.Format("Rectangle area= {0}", ar);
        }

        public string area(double r)
        {
            double c = Math.PI * r * r;
            return string.Format("Area of circle= {0}", c);
        }

        public string area(double b, int h)
        {
            double d = 0.5 * b * h;
            return string.Format("Triangle Area= {0}", d);

        }
    }
}
