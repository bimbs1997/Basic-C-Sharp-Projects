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
            Console.WriteLine("Enter the string for cheking duplicate: ");
            for (int i = 0; i < someSame.Count; i++)
            {
                Console.WriteLine(i + ":" + someSame[i]);
            }
            Console.Write("\nYour choice: ");
            string choice = Console.ReadLine().Trim();
            bool found = false;
            int count = 0;
            List<int> indexArr = new List<int>();
            for (int i = 0; i < someSame.Count; i++)
            {
                if (someSame[i] == choice)
                {
                    count++;
                    indexArr.Add(i);
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine("Entered String is not not present in list!");
            }
            else if (count >= 2)
            {
                for (int i = 0; i < indexArr.Count; i++)
                {
                    Console.WriteLine("String is present on: " + indexArr[i]);
                }
            }
            else
            {
                Console.WriteLine("String is no duplicated!");
            }

            //Part 6
            Console.WriteLine("\n----------Part 6----------\n");
            List<string> someDup = new List<string>() { "flower", "country", "country", "fly", "raid", "text", "raid", "switch", "fly", "roumer", "visual", "named", "color" };

            List<string> searchItems = new List<string>();
            foreach (string val in someDup)
            {
                found = false;
                for (int i = 0; i < searchItems.Count; i++)
                {
                    if (searchItems[i].Equals(val))
                    {
                        found = true;
                        break;
                    }
                }

                if (found == true)
                {
                    Console.WriteLine(val + " is already on list!");
                }
                else
                {
                    Console.WriteLine(val);
                    searchItems.Add(val);
                }
            }
            Console.ReadKey();
        }
    }
}
