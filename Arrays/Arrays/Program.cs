using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick a number for a surprise");
            int num = Convert.ToInt32(Console.ReadLine());



            string[] stones = { "Amethyst", "Sapphire", "Pearl", "Diamond", "Malachite" };
            
            
            if (num < 5)
            {

                Console.WriteLine("You Choose: " + stones[num]);

            }
            else
            {
                Console.WriteLine("Try again Next Time.");
                Console.ReadLine();
            }
          

            Console.WriteLine("Please pick your favorite number");
            int index = Convert.ToInt32(Console.ReadLine());

            int[] luckynum = { 11, 24, 14, 17, 9 };


            if (index < 5)
            {
                Console.WriteLine("You Choose number: " + luckynum[index]);
            }
            else
            {
                Console.WriteLine("Try again Next Time.");
                Console.ReadLine();
            }

            Console.WriteLine("Please choose a number and ill show some of top movies");
            int movie = Convert.ToInt32(Console.ReadLine());

            List<string> stringlist = new List<string>();
            stringlist.Add("Die Hard");
            stringlist.Add("Harry Potter");
            stringlist.Add("Lord of The Rings");
            stringlist.Add("The Hobbit");
            stringlist.Add("Charlie and the Chocolate Factory");


            if (movie < 5)
            {
                Console.WriteLine("You Choose movie: " + stringlist[movie]);
            }
            else
            {
                Console.WriteLine("Try again Next Time.");
               
            }
            Console.ReadLine();
        }
    }
}
