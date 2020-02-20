using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            FileOperation  fl= new FileOperation();
            int ch = 0;
            do
            {
                Console.WriteLine("Select Choice:\n1.Create \n2.Add Data To File\n3.Read File\n4.Delete File\n\n");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                          fl.CreateFile();
                        break;

                    case 2:
                          fl.AddToFile();
                        break;

                    case 3:
                        fl.DisplayFile();
                        break;

                    case 4:
                        fl.DeleteFile();
                        break;

                    default:
                        Console.WriteLine("Wrong Input");
                        break;


                }
                Console.WriteLine("Press 1 to continue...");
                ch = int.Parse(Console.ReadLine());


            } while (ch == 1);

            Console.ReadKey();
        }
    }
    }

