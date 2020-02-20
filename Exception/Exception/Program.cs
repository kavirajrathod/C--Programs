using System;

namespace Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, res;
            Console.WriteLine("Enter first number:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            num2 = int.Parse(Console.ReadLine());

            try
            {
                
                res = num1 / num2;
                Console.WriteLine("Division:{0}",res);
            }

            catch (Exception e)
            {
                Console.WriteLine("Divivde By Zero Exception", e);
            }

            finally 
            {
                Console.WriteLine("In finally block");
               
            }
        }
    }
}
