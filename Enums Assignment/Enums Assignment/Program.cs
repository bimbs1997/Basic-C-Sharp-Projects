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
                Console.Write("Eenter the current day of the week: ");
                int currentday = Convert.ToInt32(Console.ReadLine());
                DayOfWeek day;

                if(currentday > 0 && currentday < 8)
                {
                    Console.WriteLine((DayOfWeek)currentday- 1);
                    Console.ReadKey();
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
