using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What course are you in?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your course is: " + yourCourse);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("Your page number is: " + pageNumber);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”. ");
            bool yesHelp = true;
            string needhelp = Convert.ToString(yesHelp);
            Console.ReadLine();
            Console.WriteLine("What help you need?");
            bool noHelp = false;
            string noneedhelp = Convert.ToString(noHelp);
            Console.ReadLine();
            Console.WriteLine("Sounds Good.");
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string yourExperience = Console.ReadLine();
            Console.WriteLine("You Experience: " + yourExperience);
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();
            Console.WriteLine("Your Feedback: " + yourFeedback);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            Console.WriteLine("You studied today: " + studyHours + "hours");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
