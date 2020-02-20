using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{                                                                                                        
    class BankAccount
    {
        int acc_num;
        protected double balance; 
        double SimpleInterest;
        public virtual double Interestamount()
        {
            SimpleInterest = 0.8 * balance ;
            return SimpleInterest;
        }

        public void display()
        {
            Console.WriteLine("{0}\n {1}\n {2}\n", acc_num, balance, SimpleInterest);
        }
        
    }
}
