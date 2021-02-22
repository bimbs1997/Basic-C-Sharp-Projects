using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a number and i'll show you some magic.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool showmagic = false;

            while (!showmagic)
            {
                switch (number)
                {
                    case 24:
                        Console.WriteLine("you choose 24, the good energy is within you and you'll always be lucky on love. ");
                        Console.WriteLine("type a number and i'll show you some magic.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 14:
                        Console.WriteLine("you choose 14, you will always provide good vibes and loved by everyone.");
                        Console.WriteLine("type a number and i'll show you some magic.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 69:
                        Console.WriteLine("you choose 69, the pleasure is always within you but lack of love.");
                        Console.WriteLine("type a number and i'll show you some magic.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 11:
                        Console.WriteLine("you choose 11, hooray!! you guessed my favorite number. good job!");
                        showmagic = true;
                        break;
                    case 17:
                        Console.WriteLine("you choose 17, you always gonna have some good memories this year, few are bad but big. ");
                        Console.WriteLine("type a number and i'll show you some magic.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("pick a number again");
                        Console.WriteLine("type a number and i'll show you some magic.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.ReadLine();

            Console.WriteLine("Pick your Box by typing your number.");
            int digit = Convert.ToInt32(Console.ReadLine());
            bool box = false;

            do
            {
                switch (digit)
                {
                    case 40:
                        Console.WriteLine("You choose 40, Hooraay!!  You Got Brand new Apple MacBook. ");
                        Console.WriteLine("Type a number again and lets see your luck.");
                        digit = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 16:
                        Console.WriteLine("You choose 16, Hooraay!! You open the box filled with designer clothes.");
                        Console.WriteLine("Type a number again and lets see your luck.");
                        digit = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("You choose 10, Hooraay!! You won a brand QLED LG TV.");
                        Console.WriteLine("Type a number again and lets see your luck.");
                        digit = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 11:
                        Console.WriteLine("You choose 11, Hooraay!! You guessed the JACKPOT PRIZE Nissan 370z . Good JOB!");
                        box = true;
                        break;
                    case 20:
                        Console.WriteLine("You choose 20, Hooraay!! You have won a brand new xbox one series X. ");
                        Console.WriteLine("Type a number again and lets see your luck.");
                        digit = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Pick a number again");
                        Console.WriteLine("Type a number again and lets see your luck.");
                        digit = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!box);
            Console.ReadLine();

        }
    }
}
