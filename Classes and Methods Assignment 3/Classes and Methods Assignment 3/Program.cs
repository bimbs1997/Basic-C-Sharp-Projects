using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            methods method = new methods();
            //Call by value
            method.test(10, 78);

            int first = 10;
            int second = 78;

            //Call by name
            method.test(first, second);

            Console.ReadKey();
        }
    }
}
