﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Approval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? True Or False");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Qualified?");
            bool QualifiedOrNot = age > 15 &&  DUI  ||  ticket < 3;
            Console.WriteLine(QualifiedOrNot);
            Console.ReadLine();

        }
    }
}
