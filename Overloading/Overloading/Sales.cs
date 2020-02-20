using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Overloading
{
    class Sales
    {
        public string product_name;
        int quantity;
        int price;
        static double salesAmount;


        public Sales(string p_name , int q, int p)
        {
            product_name = p_name;
            quantity = q;
            price = p;

            salesAmount = salesAmount + p*q;
            
        }

        public void show()
        {
            Console.WriteLine("Product-name:{0}\n Quantity:{1}\n Price:{2}\n", product_name,quantity,price);

        }

        public void display()
        {
            Console.WriteLine("SalesAmount:{0}", salesAmount);
        }
    }
}
