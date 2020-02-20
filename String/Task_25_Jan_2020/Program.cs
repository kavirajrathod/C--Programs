using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_25_Jan_2020
{
    class Program
    {
         static void Main(string[] args) 
           {
         int[] list = { 1,2,3,4};
         int[] temp = list;
         Console.Write("Original Array: ");
         foreach (int i in list) 
            {
            Console.Write(i + " ");
            }
         Console.WriteLine();
         // reverse the array
         Array.Reverse(temp);
         Console.Write("Reversed Array: ");
         foreach (int i in temp) 
            {
            Console.Write(i + " ");
            }

            Console.WriteLine("\nTotal of even numbers: {0}", total(list));
            Console.ReadKey();
      }
   
         public static int total(int[] ar)
        {
            int total=0;

            foreach (int x in ar)
            {
                if (x % 2 == 0)
                {
                    total += x;
                }
            }
            return total;
        }
    }
  }
 
