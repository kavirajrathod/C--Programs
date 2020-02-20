using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLass_Liabaries
{
    public class Calculation
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public string add()
        {
            return string.Format("Sum= {0}", num1 + num2);
        }
        public string difference()
        {
            return string.Format("Difference= {0}", num1 - num2);
        }
        public string multiply()
        {
            return string.Format("Product= {0}", num1 * num2);
        }

        public string division()
        {
            return string.Format("Division= {0}", num1 / num2);
        }
    }
}
