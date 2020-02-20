using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexerr
{
    class Program
    {

        static void Main(string[] args)
        { 
        Product p1 = new Product { Id = 123, Name = "COMPUTER", Price = 456.12 };
        Product p2 = new Product { Id = 234, Name = "SMARTPHONES", Price = 523.12 };
        Product p3 = new Product { Id = 345, Name = "BAGS", Price = 4786.12 };

        var g = new Gencs<Product>();
            g[0] = p1;
            g[1] = p2;
            g[2] = p3;


            Console.WriteLine("{0} {1} {2}\n",g[0].Id,g[0].Name,g[0].Price);
            Console.WriteLine("{0} {1} {2}\n", g[1].Id, g[1].Name, g[1].Price);
            Console.WriteLine("{0} {1} {2}\n", g[2].Id, g[2].Name, g[2].Price);
            Console.Read();
      }
    }
}
