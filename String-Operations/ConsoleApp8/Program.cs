using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name = " Kaviraj Fulchand ";
          //  string nm1 = "Rathoda";
            string nm = "Rathod ";
            string st = name.Insert(8 , " Pamabai");
            string nn = name +  nm;
            string str=$"My full name is :{ name}{ nm}";

            Console.WriteLine("Length of String: {0}", name.Length);
            Console.WriteLine("Uppercase: {0}", name.ToUpper());
            Console.WriteLine("Lowercase: {0}", name.ToLower());
            Console.WriteLine("Concatenated: {0} ", nn);
            Console.WriteLine("$FullName: {0}", str);
            Console.WriteLine("Inserted String: {0}", st);
            Console.WriteLine("$Another Concatenation By Method: {0}", String.Concat(name,nm));
            Console.WriteLine("$Sub-String: {0}", name.Substring(5,3));
          

            string[] names = new string[] { "Kaviraj", "Damodaran", "Deepak", "Khedkar_cha_Pottya" };
            foreach (string srt in names)
            {
                 Console.WriteLine(srt);
            }

            string allnames = string.Join(",", names);
            Console.WriteLine("Allnames:{0}",allnames);

            string st1 = "Welcome To Blue Lotus Engineering College, Chennai";
            string[] words = st1.Split();

            foreach(string stree in words)
            {
                Console.WriteLine(stree);
            }

            string nstr = string.Copy(nm);
            Console.WriteLine(nstr);

            Console.WriteLine(name.IndexOf("r"));

            Console.WriteLine("{0}",string.Compare("kavi","kaviraj"));

            Console.WriteLine(names[3]);

            Console.WriteLine(name.Replace("Fulchand","Raviraj"));
            Console.ReadKey();
        }
    }
}
