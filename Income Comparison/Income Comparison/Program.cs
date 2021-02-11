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
      
           
            Console.WriteLine("Hourly Rate?");
            int HourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            
            Console.WriteLine("Hours worked per week?");
            int HoursWorked =Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Person 2");
            
            Console.WriteLine("Hourly Rate?");
            int PerHours = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            int PerWeek =Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 1");
            int YearlySalary = HourlyRate * HoursWorked * 52 ;
            Console.WriteLine(YearlySalary);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2");
            int AnnualSalary = PerHours * PerWeek * 52;
            Console.WriteLine(AnnualSalary);
            Console.ReadLine();

            Console.WriteLine("Person 1 makes more money than Person 2?");
            bool Person1orPerson2 = YearlySalary < AnnualSalary ;
            Console.WriteLine(Person1orPerson2);
            Console.ReadLine();
        }
    }
}
