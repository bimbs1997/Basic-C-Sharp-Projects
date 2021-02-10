using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();
           
            Console.WriteLine("Hourly Rate?");
            int HourlyRate = 10 + 5;
            Console.WriteLine(HourlyRate);
            Console.ReadLine();
            
            Console.WriteLine("Hours worked per week");
            int HoursWorked = 2 * 20;
            Console.WriteLine(HoursWorked);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            int PerHours = 10 + 10;
            Console.WriteLine(PerHours);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            int PerWeek = 20 + 20;
            Console.WriteLine(PerWeek);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 1");
            int YearlySalary = 600 * 52;
            Console.WriteLine(YearlySalary);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2");
            int AnnualSalary = 800 * 52;
            Console.WriteLine(AnnualSalary);
            Console.ReadLine();

            Console.WriteLine("Person 1 makes more money than Person 2?");
            bool Person1orPerson2 = 41600 < 31200;
            Console.WriteLine(Person1orPerson2);
            Console.ReadLine();
        }
    }
}
