using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Dept
    {
        int Id;
        string dept_name;

        public Dept(int Id,string dept_name)
        {
            this.Id = Id;
            this.dept_name = dept_name;

        }
        public string showdata()
        {
            return string.Format("Id:{0}\n Department-Name:{1}\n", Id, dept_name);
        }

    }
}
