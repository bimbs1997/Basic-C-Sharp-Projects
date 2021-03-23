using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Method_Assignment_1
{
    class Methods
    {
        public int Square(int x)
        {
            return x + 10;
        }

        public int Square(decimal x)
        {
            return Convert.ToInt32(x + 10);
        }
        public int Square(string x)
        {
            return Convert.ToInt32(x) + 10;
        }
    }
}
