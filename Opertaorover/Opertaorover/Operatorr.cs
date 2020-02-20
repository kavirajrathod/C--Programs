using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opertaorover
{

    class Demo
    {
        int no;
        int no1;

        public Demo()
        { }

        public Demo(int x, int y)
        {
            no = x;
            no1 = y;
        }

        public void show()
        {
            Console.WriteLine("No1: {0}  No2: {1}", no, no1);
        }

        public static Demo operator +(Demo x, Demo y)
        {
            Demo d = new Demo();
            d.no = x.no + y.no;
            d.no1 = x.no1 + y.no1;
            return d;
        }

        public static Demo operator -(Demo x, Demo y)
        {
            Demo de = new Demo();
            de.no = x.no - y.no;
            de.no1 = x.no1 - y.no1;
            return de;
        }

        public static Demo operator *(Demo x, Demo y)
        {
            Demo dei = new Demo();
            dei.no = x.no * y.no;
            dei.no1 = x.no1 * y.no1;
            return dei;
        }

        public static Demo operator /(Demo x, Demo y)
        {
            Demo deo = new Demo();
            deo.no = x.no / y.no;
            deo.no1 = x.no1 / y.no1;
            return deo;
        }
    }
}
