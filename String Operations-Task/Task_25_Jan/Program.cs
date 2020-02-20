using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_25_Jan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "Dynaneshwar bhau cha mulga ", "Khedkar boy","Nandura Cha Potta" };
            string firstname = "Kaviraj ";
            string lastname = " Rathod";
            string[] sr = display("Hi I Am Kaviraj Rathod From Latur" );
            Console.WriteLine(get(s));
            Console.WriteLine(getdata(firstname,lastname));
            
            foreach (string st in sr)
            {
                Console.WriteLine(st);
            }
            Console.ReadLine();
        }

        public static string get(string[] s)
            {
                string str = string.Join("", s);
                return str;
            }

        public static string getdata(string firstname, string lastname)
        {
            string fullname = string.Concat(firstname + lastname);
            return fullname;
        }

        public static string[] display(string sr)
        {
            string[] spl = sr.Split();
            return spl;
        }                
    }
}