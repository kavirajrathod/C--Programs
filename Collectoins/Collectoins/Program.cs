using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collectoins
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList()
            { "Kaviraj", "Damodar", "Deepak","Saurabh"};


            al.Add("Rathod");
            al.Add("Pune");

            foreach (string i in al)
            {
                Console.WriteLine(i);
            }

            al.Reverse();

            foreach (string i in al)
            {
                Console.WriteLine(i);
            }

            al.Insert(5, "Kavi");
            foreach (string i in al)
            {
                Console.WriteLine(i);
            }

            string[] str = new string[] { "Latur","Buldhana","Nagar"};
            al.SetRange(4, str);

            foreach (string a in al)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();

        }
    }
}
