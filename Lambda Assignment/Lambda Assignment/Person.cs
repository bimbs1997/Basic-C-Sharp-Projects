using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Person
    {
        string firstName;
        string lastName;

        public string FirstName{get; set;}

        public string LastName{get; set;}

        public void SayName()
        {
            Console.WriteLine("Name : " + FirstName + " " + LastName);
        }
    }
}
