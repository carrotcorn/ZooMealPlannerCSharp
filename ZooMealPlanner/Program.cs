using System;

namespace ZooMealPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
            bool close = false;

            while (!close)
            {
                // Display title as the C# Zoo Meal Planner 
                Console.WriteLine("Zoo Meal Planner");
                Console.WriteLine("************************");

                // Ask the user to choose an option.
                Console.WriteLine("Choose an animal : ");
                Console.WriteLine(" 1 - Monkey");
                Console.WriteLine(" 2 - Bear");
                Console.WriteLine(" 3 - Quit");
                Console.Write("What is your selection? ");

                string selection = Console.ReadLine();

                
            }
        }
    }
}
