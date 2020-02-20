using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Circle:Shape
    {
        public override void area(float r)
        {
            double area = Math.PI * r * r;

            Console.WriteLine("Area of circle:{0}", area);
        }
    }
}
