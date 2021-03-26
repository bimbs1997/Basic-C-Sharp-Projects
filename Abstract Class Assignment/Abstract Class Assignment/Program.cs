using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.FirstName = "Sample";
            emp.LastName = "Student";
            emp.sayName();
            Console.Write("\nImplementing quit() function: ");
            emp.Quit();

            Console.WriteLine();

            Console.Write("Using object of Inteface: ");
            IQuittable quit = new Employee();
            quit.Quit();

            Console.ReadLine();
        }
    }
}
