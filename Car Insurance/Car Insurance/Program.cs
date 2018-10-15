using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age: ");
            int ageofClient = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever received a DUI? Please type \"true\" or \"false\"");
            bool receivedDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have? ");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (ageofClient > 15 && receivedDUI == false && speedingTickets <= 3)
            {
                Console.WriteLine("true");
                Console.WriteLine("You are qualified for insurance!");
            }
            else
            {
                Console.WriteLine("false");
                Console.WriteLine("No Insurance for you...naughty naughty naughty");
            }
                
            Console.Read();
        }
    }
}
