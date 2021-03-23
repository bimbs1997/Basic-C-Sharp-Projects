using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intefaces_Assignment
{
    class Employee : Person
    {
        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public override void sayName()
        {
            Console.WriteLine("Name: " + base.FirstName + " " + base.LastName);
        }
    }
}
