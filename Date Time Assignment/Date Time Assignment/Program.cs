using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString());

            Console.Write("How many hours you want to add: ");
            double num = Convert.ToDouble(Console.ReadLine());

            DateTime newDate = dateTime.AddHours(num);
            Console.WriteLine("Exact time after " + num + " hours will be: " + newDate.ToShortTimeString());
            Console.ReadKey();
        }
    }
}
