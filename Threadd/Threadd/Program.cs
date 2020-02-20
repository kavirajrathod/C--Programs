using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Xml;

namespace Threadd
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(get);
            Thread th = new Thread(ts);
            th.Start();
            ThreadStart tse = new ThreadStart(show);
            Thread the = new Thread(tse);
            the.Start();
            
            Console.ReadKey();
        }

        public static void show()
        {
            for (int i = 0; i < 10; i++)
            {
                
                Thread.Sleep(300);
                Console.WriteLine(i);
            }
        }

        public static void get()
        {
            for (int i = 0; i <= 20; i++)
            {
                Thread.Sleep(300);
                Console.WriteLine(i);
            }
        }
    }
}
