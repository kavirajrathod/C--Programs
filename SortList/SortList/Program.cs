using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("Kaviraj",100);
            sl.Add("Rathod", 200);
            sl.Add("Latur", 300);

            ICollection key = sl.Keys;
            foreach (string i in key)
            {
                Console.WriteLine(i +":"+ sl[i]);
            }

            Console.ReadKey();

        }
    }
}
