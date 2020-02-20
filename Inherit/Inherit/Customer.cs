using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Customer
    {
        int cid;
        string cust_name;
        string address;
        BankAccount b;

        public Customer(int cid,string cust_name,string address,BankAccount b)
        {
            this.cid = cid;
            this.cust_name = cust_name;
            this.address = address;
            this.b = b;
        }

        public void Show()
        {
            Console.WriteLine("{0}\n {1}\n {2}\n {3}", cid, cust_name, address, b.Interestamount());
        }
            
    }
}
