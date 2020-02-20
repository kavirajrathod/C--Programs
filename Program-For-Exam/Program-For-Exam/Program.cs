using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Program_For_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating and Adding Elements into ArrayList:\n");
            ArrayList al = new ArrayList()
            { "Kaviraj", "Damodar", "Deepak","Saurabh"};


            al.Add("Rathod");
            al.Add("Pune");

           
            foreach (string i in al)
            {
                Console.WriteLine(i);
            }       

            Console.WriteLine("\nReverse ArrayList\n");

            al.Reverse();

            foreach (string i in al)
            {
                 Console.WriteLine(i);
            }

            Console.WriteLine("\nInsert Elements at Specified Location\n");

            al.Insert(5, "Kavi");
            foreach (string i in al)
            {
                 Console.WriteLine(i);
            }

            Console.WriteLine("\nSetRange\n");

            string[] str = new string[] { "Latur", "Buldhana", "Nagar" };
            al.SetRange(4, str);

            foreach (string a in al)
            {
                 Console.WriteLine(a);
            }
                       
            Console.ReadKey();

        }

    }
 }

