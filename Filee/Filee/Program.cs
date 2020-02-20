using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ControlzEx.Standard;

namespace Filee
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Admin\Desktop\C#.txt";
            if(!File.Exists(path))
            {
                using(StreamWriter sw = File.CreateText(path)) 
                {
                    Console.WriteLine("Enter ID:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Address:");
                    string address =Console.ReadLine();
                    sw.WriteLine("My ID Is:" + id);
                    sw.WriteLine("My name Is:" + name);
                    sw.WriteLine("My address Is:" + address);
                }
            }
              
                  //Open the file to read from:
                using (StreamReader sr = File.OpenText(path))
                {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }

                }


            using (StreamWriter st = File.AppendText(path))
            {
                Console.WriteLine("Enter some text:");
                string s = Console.ReadLine();
                st.WriteLine(s);
             }

            using (StreamReader stt = File.OpenText(path))
            {
                string s;
                while ((s = stt.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

                Console.ReadKey();
        }
    }
}
