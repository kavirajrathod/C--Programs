using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedLis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class1> slist = new List<Class1>();
            slist.Add(new Class1 { Cid = 1, Cname = "C#", StartDate=DateTime.Today,Fees = 500000 });
            slist.Add(new Class1 { Cid = 2, Cname = "Java", StartDate = DateTime.Parse("22-Jan-2018"), Fees = 220000 });
            slist.Add(new Class1 { Cid = 3, Cname = "HTML", StartDate = DateTime.Parse("30-Dec-2019"), Fees = 150000 });

            foreach (Class1 cl in slist)
            {
                Console.WriteLine("Course_Id: {0}\t \nCourse_Name: {1}\t \nStartDate: {2}\t \nFees:{3}\n", cl.Cid,cl.Cname,cl.StartDate,cl.Fees);
            }


            HashSet<Class1> hset = new HashSet<Class1>();
            hset.Add(new Class1 { Cid = 4, Cname = "Python", StartDate = DateTime.Today, Fees = 5000 });
            hset.Add(new Class1 { Cid = 5, Cname = "JavaScript", StartDate = DateTime.Parse("21-Feb-2020"), Fees = 2000 });
            hset.Add(new Class1 { Cid = 6, Cname = "ADO.NET", StartDate = DateTime.Parse("01-May-2010"), Fees = 5000 });
            
            foreach (Class1 cl in hset)
            {
                Console.WriteLine("Course_Id: {0}\t \nCourse_Name: {1}\t \nStartDate: {2}\t \nFees:{3}\n", cl.Cid, cl.Cname, cl.StartDate, cl.Fees);
            }

            Console.WriteLine("STACK PUSH:");
            Stack<Class1> s = new Stack<Class1>();
            s.Push(new Class1 { Cid = 7, Cname = "ASP.NET", StartDate = DateTime.Today, Fees = 55000 });
            s.Push(new Class1 { Cid = 8, Cname = "XML", StartDate = DateTime.Parse("21-Feb-2020"), Fees = 25000 });
            s.Push(new Class1 { Cid = 9, Cname = "C++", StartDate = DateTime.Parse("01-May-2010"), Fees = 55000 });

            foreach (Class1 cl in s)
            {
                Console.WriteLine("Course_Id: {0}\t \nCourse_Name: {1}\t \nStartDate: {2}\t \nFees:{3}\n", cl.Cid, cl.Cname, cl.StartDate, cl.Fees);
            }


            Console.WriteLine("STACK POP:");
            s.Pop();

            foreach (Class1 cl in s)
            {
                Console.WriteLine("Course_Id: {0}\t \nCourse_Name: {1}\t \nStartDate: {2}\t \nFees:{3}\n", cl.Cid, cl.Cname, cl.StartDate, cl.Fees);
            }


            Console.WriteLine("QUEUE ENQUEUE:");
            Queue<Class1> q = new Queue<Class1>();
            q.Enqueue(new Class1 { Cid = 10, Cname = "C", StartDate = DateTime.Today, Fees = 55000 });
            q.Enqueue(new Class1 { Cid = 11, Cname = "AI", StartDate = DateTime.Parse("21-Feb-2020"), Fees = 25000 });
            q.Enqueue(new Class1 { Cid = 12, Cname = "ASSEMBLY", StartDate = DateTime.Parse("01-May-2010"), Fees = 55000 });
           
            foreach (Class1 cl in q)
            {
                Console.WriteLine("Course_Id: {0}\t \nCourse_Name: {1}\t \nStartDate: {2}\t \nFees:{3}\n", cl.Cid, cl.Cname, cl.StartDate, cl.Fees);
            }

            Console.WriteLine("QUEUE DEQUEUE:");
            q.Dequeue();

            foreach (Class1 cl in q)
            {
                Console.WriteLine("Course_Id: {0}\t \nCourse_Name: {1}\t \nStartDate: {2}\t \nFees:{3}\n", cl.Cid, cl.Cname, cl.StartDate, cl.Fees);
            }

            Console.WriteLine("DICTIONARY:");

            Dictionary<int,Class1> dc = new Dictionary<int,Class1>();
            dc.Add(1, new Class1 { Cid = 1, Cname = "C#", StartDate = DateTime.Today, Fees = 500000 });
            dc.Add(2, new Class1 { Cid = 2, Cname = "Java", StartDate = DateTime.Parse("22-Jan-2018"), Fees = 220000 });
            dc.Add(3, new Class1 { Cid = 3, Cname = "HTML", StartDate = DateTime.Parse("30-Dec-2019"), Fees = 150000 });

            foreach (KeyValuePair<int,Class1> d in dc)
            {
                Console.WriteLine("{0} {1} {2} {3}",d.Key, d.Value.Cid, d.Value.Cname, d.Value.StartDate,d.Value.Fees);
            }

            Console.WriteLine("\n SORTED DICTIONARY:");

            SortedDictionary<int, Class1> sd = new SortedDictionary<int, Class1>();
            sd.Add(1, new Class1 { Cid = 1, Cname = "C#", StartDate = DateTime.Today, Fees = 500000 });
            sd.Add(2, new Class1 { Cid = 2, Cname = "Java", StartDate = DateTime.Parse("22-Jan-2018"), Fees = 220000 });
            sd.Add(3, new Class1 { Cid = 3, Cname = "HTML", StartDate = DateTime.Parse("30-Dec-2019"), Fees = 150000 });

            foreach (KeyValuePair<int, Class1> d in dc)
            {
                Console.WriteLine("{0} {1} {2} {3}", d.Key, d.Value.Cid, d.Value.Cname, d.Value.StartDate, d.Value.Fees);
            }
            Console.ReadKey();
        }
    }
}
