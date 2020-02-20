using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEL
{
    class Program
    {
        public delegate string Mydel(int x, int y);
        public delegate double Mydel1(int x);
    
        static void Main(string[] args)
        {
            Mydel del1 = new Mydel(add);
            Mydel del2 = new Mydel(sub);

           
            Console.WriteLine(del1(12,12));        
            Console.WriteLine(del2(10,5));

            Mydel1 dl = new Mydel1(area);
            Console.WriteLine(dl(3));

            Console.ReadKey();
        }


        public static string add(int a, int b)
        {
            int c = a + b;
            return string.Format("Addition:{0}", c);
        }

        public static string sub(int a, int b)
        {
            int c = a - b;
            return string.Format("Substraction:{0}", c);
        }

        public static double area(int r)
        {
            return Math.PI * r * r;
        }

        
    }
}
