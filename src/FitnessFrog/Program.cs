using System;

namespace FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            var runningTotal = 0;

            while(true)
            {
                //prompt user for minutes exercised
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                //Add minutes exercised to total
                var minutes = int.Parse(input);
                runningTotal += minutes;

                //Display total minutes exercised to the screen
                Console.WriteLine("You have exercised {0} minutes", runningTotal);

                //Repeat until user quit
            }

            Console.WriteLine("Goodbye");
        }

    }
}
