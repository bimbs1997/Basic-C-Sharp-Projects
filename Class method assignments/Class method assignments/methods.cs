using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_method_assignments
{
    static class methods
    {
        public static void divide(int x)
        {
            x = x / 2;
            Console.WriteLine("After Dividing: " + x);
        }

        public static void sumOut(out int x, out int y)
        {
            x = 90;
            y = 100;
        }

        //Method overload by changing number of parameter
        public static void  sumOut(out int x)
        {
            x = 70;
        }


    }
}
