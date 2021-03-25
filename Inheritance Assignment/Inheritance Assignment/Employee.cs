using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    class Employee : Person
    {
        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public void SayName()
        {
            base.SayName();
        }
        
    }
}
