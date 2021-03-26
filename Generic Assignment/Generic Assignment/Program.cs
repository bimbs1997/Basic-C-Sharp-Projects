using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> emp = new Employee<string>();
            
            emp.Things.Add("abc");
            emp.Things.Add("def");
            emp.Things.Add("ghi");
            emp.Things.Add("jkl");

            Console.WriteLine("When Data type is String: ");
            for(int i = 0; i < emp.Things.Count; i++)
            {
                Console.WriteLine(emp.Things[i]);
            }

            Console.WriteLine();

            Console.WriteLine("When Data type is INT: ");
            Employee<int> empInt = new Employee<int>();
            empInt.Things.Add(1);
            empInt.Things.Add(2);
            empInt.Things.Add(3);
            empInt.Things.Add(4);

            for (int i = 0; i < empInt.Things.Count; i++)
            {
                Console.WriteLine(empInt.Things[i]);
            }

            Console.ReadKey();
        }
    }
}
