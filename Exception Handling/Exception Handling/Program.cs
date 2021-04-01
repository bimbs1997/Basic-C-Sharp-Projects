using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class NegativeNumberNotAllowed : Exception
    {
          
    }
    class Program : Exception
    {
        static void Main(string[] args)
        {
            int age;
            try
            {
                Console.Write("Enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());
                if(age < 0)
                {
                    throw new Exception("Negative numbers are not allowed!");
                }
                else if(age == 0)
                {
                    throw new Exception("Number must be greater to 0!");
                }
                else
                {
                    int currentYear = DateTime.Now.Year;
                    int birthYear = currentYear - age;
                    Console.WriteLine("Your birth year is: " + birthYear);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            Console.ReadKey();
        }
    }
}
