using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.area(1);
            Aeroplane a = new Aeroplane();
            a.fly();
            Helicopter h = new Helicopter();
            h.fly();

            Console.ReadKey();
        }
    }
}
