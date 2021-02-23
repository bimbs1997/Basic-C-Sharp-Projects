using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "<Emerson>";
            userName = userName.ToUpper();
            string dateString = DateTime.Today.ToShortDateString();

            // Use the + and += operators for one-time concatenations.
            string str = "Hello " + userName + ". Today is " + dateString + ".";

            System.Console.WriteLine(str);
            Console.ReadLine();


            str += " How are you today?";
            System.Console.WriteLine(str);
            Console.ReadLine();

            StringBuilder fsb = new StringBuilder();

            fsb.Append("Life isn't about finding yourself. Life is about creating yourself.");
            Console.WriteLine(fsb);
            Console.ReadLine();

            StringBuilder ssb = new StringBuilder();

            ssb.Append("Sometimes people are beautiful. Not in what they say. Just in what they are.");
            Console.WriteLine(ssb);
            Console.ReadLine();

            StringBuilder tsb = new StringBuilder();

            tsb.Append("Life is like riding a bicycle. To keep your balance, you must keep moving.");
            Console.WriteLine(tsb);
            Console.ReadLine();


        }
    }
}
