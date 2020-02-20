using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Hasha
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable h = new Hashtable();
            h.Add("Kaviraj", 123);
            h.Add("Damodar", 124);
            h.Add("Deepak", 125);

            ICollection key = h.Keys;
            foreach (string i in h.Values)
            {
                Console.WriteLine(i +":"+ h[i]);
            }

            h.Remove("Deepak");                              //Remove
            foreach (string i in key)
            {
                Console.WriteLine(i + ":" + h[i]);
            }



            Console.ReadKey();
        }
    }
}
