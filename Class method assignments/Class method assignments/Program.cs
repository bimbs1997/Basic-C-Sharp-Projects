using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_method_assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number for divided it by 2: ");
            int num = Convert.ToInt32(Console.ReadLine());

            methods.divide(num);

            int x = 20,y = 50;
            Console.WriteLine("Value of x before Out Parameter mehtod: "+x+"\nValue of y before Out Parameter method: "+ y);
            methods.sumOut(out x, out y);

            Console.WriteLine("\nValue of x after Out Parameter mehtod: " + x + "\nValue of y after Out Parameter method: " + y);

            //Overloaded
            methods.sumOut(out x);
            Console.WriteLine("\nValue of x after overlading Out Parameter mehtod: " + x );

            Console.ReadKey();
        }
    }
}
