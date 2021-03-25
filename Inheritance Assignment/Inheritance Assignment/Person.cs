using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    class Person
    {
        string firstName;
        string lastName;

        public string FirstName
        {
            get { return firstName;}
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName;}
            set { lastName = value; }
        }

        public void SayName()
        {
            Console.WriteLine("Name : " + FirstName + " " + LastName);
        }

        
    }
}
