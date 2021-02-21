using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Quote_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight:");
            int pweight = Convert.ToInt32(Console.ReadLine());


            if (pweight < 50)
            {
                Console.WriteLine("The Package is weight is perfect!");
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine(); 
                Environment.Exit(0);
            }
            Console.WriteLine("Please enter the package width:");
            int pwidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int pheight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int plength = Convert.ToInt32(Console.ReadLine());

            if (pwidth < 50 && pheight < 50 && plength < 50)
            {
                
                decimal quote = Convert.ToDecimal(pwidth * pheight * plength * pweight / 100);
                Console.WriteLine("Your estimated total for shipping this package is:$" + quote);
                Console.WriteLine("Thank you for your patience. Have A Great Day!");
                Console.ReadLine();         
            }
            else
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

















        }
    }
}
