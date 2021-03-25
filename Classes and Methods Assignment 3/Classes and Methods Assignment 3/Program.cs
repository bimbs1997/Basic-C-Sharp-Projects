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
            methods obj = new methods();
            //Passing numbers as parameter
            Console.Write("Output when we pass numbers as Parameter: ");
            obj.test(10, 78);

            int first = 10;
            int second = 78;

            //Passing name as parameter
            Console.Write("Output when we pass Name as Parameter: ");
            obj.test(first, second);


            Console.ReadKey();
        }
    }
}
