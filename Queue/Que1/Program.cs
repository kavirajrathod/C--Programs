﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Que1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(123);
            q.Enqueue(234);
            q.Enqueue(345);
            
            foreach (int i in q)
            {
                Console.WriteLine(i);
            }
            q.Dequeue();

            foreach (int i in q)
            {
                Console.WriteLine(i);
            }



            Console.ReadKey();
        }
    }
}
