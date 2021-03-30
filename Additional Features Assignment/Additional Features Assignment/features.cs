using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features_Assignment
{
    class features
    {
        const int constVariable = 10;
        public features() : this(constVariable)
        {

        }

        public features(int variable)
        {
            var temp = constVariable;
            variable = temp;
            Console.WriteLine("Const variable value in chaining constructor: " + variable);
        }
    }
}
