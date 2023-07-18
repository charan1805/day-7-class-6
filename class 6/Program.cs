using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_6
{
   

namespace DirectoryExample
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                



                string fPath;
                Console.WriteLine("Input Directory Path: ");
                fPath = Console.ReadLine();
                DirectoryInfo directory = new DirectoryInfo(fPath);
                foreach (FileInfo file in directory.GetFiles())
                {
                    Console.WriteLine(" File Full Name: \t" + file.FullName);
                    Console.WriteLine("\tFile Length: " + file.Length);
                    Console.WriteLine("\tFile Creation Time: " + file.CreationTime);
                    Console.WriteLine("\n");
                }
                Console.ReadKey();
            }

        }
    }
}
    

