using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"D:\IOAssignment.txt";

            try
            {
                TextWriter tw = new StreamWriter(fileName);
                Console.Write("Enter number: ");
                tw.Write(Convert.ToInt32(Console.ReadLine()));
                tw.Close();

                Console.Write("\nText into the text file is : ");
                using (StreamReader sr = File.OpenText(fileName))
                {   
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            Console.ReadKey();
        }
    }
}
