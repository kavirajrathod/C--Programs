using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Category
    {
        int num;
        string type;

        public Category(int num, string type)
        {
            this.num = num;
            this.type = type;

        }
        public string putdataa()
        {
            return string.Format("NUM:{0}\n Category-Name:{1}\n", num, type);
        }

    }
}