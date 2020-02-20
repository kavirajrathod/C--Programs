using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatesss
{
    class Program
    {
        static void Main(string[] args)
        {
          

            List<Student> lst = new List<Student>
            {
             new Student { ID=1,Stud_name="Kaviraj",Course="PYTHON"},
             new Student { ID=2,Stud_name="Ravi",Course="C#"},
             new Student { ID=3,Stud_name="Damodar",Course="C"},
             new Student { ID=4,Stud_name="Yash",Course="JAVA"},
            };

          


            List<Student> s = Listdemo(lst);

            foreach (var a in s)
            {
                Console.WriteLine("{0}  {1}  {2}", a.ID, a.Stud_name, a.Course);
            }
            Console.ReadKey();
        }

        public static List<Student> Listdemo(List<Student> lst)
        {
            lst.Sort((x, y) => x.ID.CompareTo(y.ID));
            return lst;

        }
       
    }
}
