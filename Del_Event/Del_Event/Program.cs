using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del_Event
{
    class Program
    {
        public delegate void delEvent();
        public static event delEvent handler;
        static void Main(string[] args)
        {
            handler += new delEvent(Circle);
            handler += new delEvent(Square);
            handler.Invoke();
            Console.ReadKey();
        }

        static void Circle()
        {
            double r = 5;
            double res = Math.PI * r * r;
            Console.WriteLine("Area Of Circle:{0}", res);
        }

        static void Square()
        {
            double s = 5;
            
            Console.WriteLine("Area Of Square:{0}", s*s);
        }


    }
}
