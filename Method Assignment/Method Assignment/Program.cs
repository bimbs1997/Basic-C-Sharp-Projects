using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            methods method = new methods();
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Square : " + method.square(num));
            Console.WriteLine("Cube : " + method.cube(num));
            Console.WriteLine("Half : " + method.half(num));

            Console.ReadKey();
        }
    }
}
