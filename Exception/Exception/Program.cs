using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){
                10,4,7,3,5,7,3,2,4,6,7,32
            };

            Console.WriteLine("Before Try Catch!");
            try
            {
                Console.Write("\nEnter number to divide the numbers in list: ");
                int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.WriteLine(numbers[i] / num);
                }
            }catch (Exception ex)
            {
                if (ex is DivideByZeroException)
                {
                    Console.WriteLine("Error: Can't Divided by Zero!");
                }
                if (ex is FormatException)
                {
                    Console.WriteLine("Error: Can't divided by string and characters!");
                }
            }

            Console.WriteLine("\nThis code executed after try catch!");
            Console.ReadKey();
        }
    }
}
