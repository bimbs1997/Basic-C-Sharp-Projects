using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorite number.");
            int Cardnumber = Convert.ToInt32(Console.ReadLine());
            Cardnumber = Cardnumber * 50;
            Console.WriteLine(Cardnumber);
            Console.ReadLine();

            Console.WriteLine("Add up your result on 1st step.");
            int Secondnumber = Convert.ToInt32(Console.ReadLine());
            Secondnumber = Secondnumber + 25;
            Console.WriteLine(Secondnumber);
            Console.ReadLine();

            Console.WriteLine("Divide your result on 2nd step");
            double Thirdnumber = Convert.ToInt32(Console.ReadLine());
            Thirdnumber = Thirdnumber / 12.5;
            Console.WriteLine(Thirdnumber);
            Console.ReadLine();

            Console.WriteLine("3rd step Lets see if its TRUE or FALSE");
            int Fourthnumber = Convert.ToInt32(Console.ReadLine());
            bool TrueOrFalse = Fourthnumber > 50;
            Console.WriteLine(TrueOrFalse.ToString());
            Console.ReadLine();

            Console.WriteLine("Please enter the last 2 digit on the 3rd step");
            int remainder = Convert.ToInt32(Console.ReadLine());
            remainder = remainder % 7;
            Console.WriteLine(remainder);
            Console.WriteLine("That's Your Lucky Number Hooray!!");
            Console.ReadLine();




        }
    }
}
