using System;

namespace FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {

            //prompt user for minutes exercised
            Console.Write("Enter how many minutes you exercised: ");
            var input = Console.ReadLine();

            //Add minutes exercised to total
            //Display total minutes exercised to the screen
            Console.WriteLine("You have exercised {0} minutes", input);
            //Repeat until user quit
        }
    }
}
