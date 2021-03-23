using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_methods_assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            methods method = new methods();

            int first, second;
            string choice;
            Console.Write("Enter first number: ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nSecond number is optional! Do you want to enter? Press 'y' or 'Y' for it : ");
            choice = Console.ReadLine();
            if(choice == "y" || choice == "Y")
            {
                Console.Write("\nEnter Second number: ");
                second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nAnswer: " + method.sum(first, second));
            }
            else
            {
                Console.WriteLine("\nAnswer: " + method.sum(first));
            }
            Console.ReadKey();
        }
    }
}
