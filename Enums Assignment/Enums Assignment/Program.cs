using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Assignment
{
    class Program
    {
        enum DayOfWeek { sunday, monday, tuesday, wednesday, thursday, friday, saturday }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ernter the current day of the week: ");
                string currentday = Console.ReadLine();
                DayOfWeek day;

                if (Enum.TryParse<DayOfWeek>(currentday, out day))
                {
                    Console.WriteLine("Current Day is: " + currentday);
                }
                else
                {
                    throw new OverflowException();
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter a actual day of week!");
            }
            Console.ReadKey();
        }
    }
}
