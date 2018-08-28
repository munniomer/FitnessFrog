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

                if (minutes <= 0)
                {
                    Console.WriteLine(minutes + " is not an acceptable value.");
                    continue;
                }

                else if (minutes <= 10)
                    Console.WriteLine("Better than nothing, am I right?");
                else if (minutes <= 30)
                    Console.WriteLine("Way to go hot stuff!");
                else if (minutes <= 60)
                    Console.WriteLine("You must be a ninja warrior in training");
                else
                    Console.WriteLine("Okay, now you are just showing off!");
                    
                runningTotal += minutes;

                //Display total minutes exercised to the screen
                Console.WriteLine("You have exercised {0} minutes", runningTotal);

                //Repeat until user quit
            }

            Console.WriteLine("Goodbye");
        }

    }
}
