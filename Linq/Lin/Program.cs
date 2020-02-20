using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lin
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> lst = new List<Student>()
            {

            new Student { Roll_no = 54, stud_name = "Kaviraj", Class = "BEIT", marks = 9.5 },
            new Student { Roll_no = 52, stud_name = "Damodar", Class = "TEIT", marks = 8.6 },
            new Student { Roll_no = 51, stud_name = "Deepak", Class = "SEIT", marks = 7 },
            new Student { Roll_no = 50, stud_name = "Raj", Class = "BEIT", marks =6.5 }};


            Console.WriteLine("Data");
            var q = from aq in lst
                    select aq;

            foreach (var qe in q)
            {
                Console.WriteLine("Roll_Number:{0}  Student_Name:{1}  Class:{2}  Marks:{3}",qe.Roll_no,qe.stud_name,qe.Class,qe.marks);
            }

            Console.WriteLine("\nOrder By::");
            var qa = from aa in lst
                     orderby aa.Roll_no
                     select aa;

            foreach (var g in qa)
            {
                Console.WriteLine("Roll_Number:{0}  Student_Name:{1}  Class:{2}  Marks:{3}", g.Roll_no, g.stud_name, g.Class, g.marks);
            }

            Console.WriteLine("\nWhere Clause::");
            var qb = from ab in lst
                     where ab.Roll_no==54 
                     select ab;

            foreach (var gg in qb)
            {
                Console.WriteLine("Roll_Number:{0}  Student_Name:{1}  Class:{2}  Marks:{3}", gg.Roll_no, gg.stud_name, gg.Class, gg.marks);
            }

            

            Console.ReadKey();
        }
    }
}
