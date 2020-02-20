using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class sample
    {

        int no = 0;
        static int cnt = 0;

        public sample()
        {
            no++;
            cnt++;
            //Console.WriteLine("count:{0}", cnt);
        }
         public static void show()
        {
            Console.WriteLine("Static Method and count is: {0}",cnt);
        }  
    }
}
