using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Product
    {
        int id, price;
        string name;
        Category cg;       

        public Product(int id, string name, int price, Category cg)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.cg = cg;
        }


        public void showdataa()
        {
            Console.WriteLine("ID:{0}\n NAME:{1}\n PRICE:{2}\n {3}", id, name, price, cg.putdataa());
        }
    }
}
