using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Assignment
{
    class Employee : Person
    {
        public int Id {get; set;}

        public void SayName()
        {
            base.SayName();
        }

        //Overloading the == operator for compairing the Employee ID
        public static bool operator == (Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }

        //We have to ovveride the != operator when we try to override == operator
        public static bool operator != (Employee emp1, Employee emp2)
        {
            return emp1.Id != emp2.Id;
        }
    }
}
