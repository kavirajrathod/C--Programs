using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task
{
    class FileOperation
    {
            public void CreateFile()
            {
                string path = @"C:\Users\Admin\Desktop\demo.txt";
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("My name is Kaviraj");
                        sw.WriteLine("I am from Latur");
                      
                        sw.Flush();
                    }
                }
            }

            public void DisplayFile()
            {
                string path = @"C:\Users\Admin\Desktop\demo.txt";
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }

                }
            }

            public void AddToFile()
            {
                string path = @"C:\Users\Admin\Desktop\demo.txt";
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("My Fav singer is arijit singh");                
                    sw.WriteLine("Working in cognizant chennai");
                    sw.Flush();
                }
            }

            public void DeleteFile()
            {

                string path = @"C:\Users\Admin\Desktop\demo.txt";
                File.Delete(path);
                Console.WriteLine("File Deleted Successfully...");
            }
        }
}
