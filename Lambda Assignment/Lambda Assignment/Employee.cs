using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Employee : Person
    {
        public int Id {get; set;}

        public Employee(string FirstName, string LastName, int id)
        {
            base.FirstName = FirstName;
            base.LastName = LastName;
            Id = id;
        }
        public void  SayName()
        {
            base.SayName();
        }
    }
}
