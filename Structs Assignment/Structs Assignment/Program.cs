using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Assignment
{
    struct Numbers
    {
        decimal amount;
        public decimal Amount {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Numbers num = new Numbers();
            num.Amount = 10;

            Console.WriteLine("Amount is: " + num.Amount);
            Console.ReadKey();
        }
    }
}
