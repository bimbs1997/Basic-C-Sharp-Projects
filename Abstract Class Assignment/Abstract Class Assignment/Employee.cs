using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Employee : Person, IQuittable
    {
        public int Id {get; set;}

        public override void sayName()
        {
            Console.WriteLine("Name: " + base.FirstName + " " + base.LastName);
        }

        public void Quit()
        {
            Console.WriteLine("I Quit!");
        }

    }
}
