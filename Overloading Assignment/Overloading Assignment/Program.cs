using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            emp1.Id = 10;
            emp2.Id = 10;

            Console.WriteLine("When Both Id's are same: ");
            if(emp1 == emp2)
            {
                Console.WriteLine("Both id are same!");
            }
            else
            {
                Console.WriteLine("Id's are different!");
            }

            emp1.Id = 10;
            emp2.Id = 20;
            Console.WriteLine("\nWhen Both Id's are Different: ");
            if (emp1 == emp2)
            {
                Console.WriteLine("Both id are same!");
            }
            else
            {
                Console.WriteLine("Id's are different!");
            }
            Console.ReadKey();
        }
    }
}
