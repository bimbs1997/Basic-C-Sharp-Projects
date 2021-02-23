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

            StringBuilder fsb = new StringBuilder("Life isn't about finding yourself.", 100);

            fsb.Append("Life is about creating yourself.");
            fsb.AppendFormat("Life is what happens when you're busy making other plans." );
            fsb.Append("We are here to add what we can to life, not to get what we can from life");
            Console.WriteLine(fsb);
            Console.ReadLine();

        }
    }
}
