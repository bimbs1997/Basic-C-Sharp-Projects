using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Method_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            decimal number;
            string val;
            Methods method = new Methods();
            
            //Integer Parameter
            Console.Write("Enter number for integer parameter method: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Return value of integer parameter method: " + method.Square(num));

            //Decimal parameter
            Console.Write("\n\nEnter number for Decimal parameter method: ");
            number = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Return value of Decimal parameter method: " + method.Square(number));

            //String parameter
            Console.Write("\n\nEnter number for String parameter method: ");
            val = Console.ReadLine();
            Console.Write("Return value of integer parameter method: " + method.Square(val));

            Console.ReadKey();
        }
    }
}
