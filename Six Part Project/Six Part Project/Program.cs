using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Part_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            Console.WriteLine("----------Part 1----------\n");
            string text;
            string[] arr = { "Joe", "Joe Root", "Canada", "Australia", "Pakistan", "Love", "Flowers" };
            Console.Write("Enter any text: ");
            text = Console.ReadLine();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] + text;
            }
            Console.WriteLine("\nElements of array are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //Part 2
            Console.WriteLine("\n----------Part 2----------\n");
            //Infinite loop!
            //for(int i = 0; i < arr.Length; i-- )
            //{
            //    Console.WriteLine("It is infinite loop!");
            //}

            //Finite loop!
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("It is finite loop!");
            }
            Console.WriteLine();

            //Part 3
            Console.WriteLine("\n----------Part 3----------\n");
            Console.WriteLine("Output by using '<' Operator: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("\nOutput by using '<=' Operator:");
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i]);
            }


            //Part 4
            Console.WriteLine("\n----------Part 4----------\n");
            List<string> unique = new List<string>(){
                "flower", "country", "fly", "text", "result", "switch"
            };
            Console.Write("Enter text for search: ");
            string search = Console.ReadLine();
            bool searched = false;
            int index = 0;
            do
            {
                if (String.Equals(unique[index], search.Trim()))
                {
                    Console.WriteLine("String found! Its index is: " + index);
                    searched = true;
                    break;
                }
                index++;
            } while (searched == false && index < unique.Count);

            if (searched == false)
            {
                Console.WriteLine("String not found!");
            }

            //Part 5
            Console.WriteLine("\n----------Part 5----------\n");
            List<string> someSame = new List<string>(){
                "flower", "country", "fly", "text", "raid", "switch", "fly", "roumer", "visual", "named", "color"
            };
            Console.WriteLine("Select the string for cheking duplicate by input the index number: ");
            for (int i = 0; i < someSame.Count; i++)
            {
                Console.WriteLine(i + ":" + someSame[i]);
            }
            Console.Write("\nYour choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            if (choice >= 0 && choice < someSame.Count)
            {
                for (int i = 0; i < someSame.Count; i++)
                {
                    if (i == choice)
                    {
                        continue;
                    }
                    if (someSame[i] == someSame[choice])
                    {
                        Console.WriteLine("\nString Present at: " + i);
                        found = true;
                    }
                }
                if (found == false)
                {
                    Console.WriteLine("\nString is not duplicated in array!");
                }
            }
            else
            {
                Console.WriteLine("\nYou choose wrong index!");
            }

            //Part 6
            Console.WriteLine("\n----------Part 6----------\n");
            List<string> someDup = new List<string>() { "flower", "country", "fly", "text", "raid", "switch", "fly", "roumer", "visual", "named", "color" };

            int counter = 0;
            foreach (string val in someDup)
            {
                found = false;
                for (int i = 0; i < counter; i++)
                {
                    if (someDup[i].Equals(val))
                    {
                        Console.WriteLine(val + " is already on the list");
                        found = true;
                        break;
                    }
                }
                if (found == false)
                {
                    Console.WriteLine(val);
                }
                counter++;
            }
            Console.ReadKey();
        }
    }
}
