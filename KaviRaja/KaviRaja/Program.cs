using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaviRaja
{
    class Program
    {
        static ModelKaviContainer db = new ModelKaviContainer();
        static void Main(string[] args)
        {
            //Insertdata();
            Display();
            Console.Read();
        }

        public static void Insertdata()
        {
            Console.WriteLine("Enter the Category Id");
            int cid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Category name");
            string ctl = Console.ReadLine();


            var category = new Categary
            {
                Cid = cid,
                Ctytle = ctl

            };

            db.Categaries.Add(category);
            db.SaveChanges();


            Console.WriteLine("Enter the Product Id");
            int pid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Title");
            string ttl = Console.ReadLine();
            Console.WriteLine("Enter Price");
            int pr = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Cid");
            int ccid = int.Parse(Console.ReadLine());


            var product = new Product
            {
                Pid = pid,
                Ptytle = ttl,
                Price = pr,

                Cid = ccid

            };
            db.Products.Add(product);
            db.SaveChanges();
        }


        public static void Display()
        {
            Console.WriteLine("All Categories are::\n");
            var Category = db.Categaries;
            foreach (var c in Category)
            {
                Console.WriteLine("{0}\t{1}", c.Cid, c.Ctytle);
            }

            Console.WriteLine();

            Console.WriteLine("All Products are::\n");
            var product = db.Products;
            foreach (var d in product)
            {
                Console.WriteLine("{0}\t{1}\t{2}", d.Pid, d.Ptytle, d.Price);
            }
        }
    }
}
