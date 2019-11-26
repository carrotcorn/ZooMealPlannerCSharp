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

                while (!selection.Equals("1") && !selection.Equals("2"))
                {
                    Console.WriteLine("Choose a valid option");
                    selection = Console.ReadLine();
                }

                switch (selection)
                {
                    case "1":
                        Monkey myMonkey = new Monkey();
                        break;
                    case "2":
                        Bear myBear = new Bear();
                        break;
                }
                
                Console.Write("Press '3' & enter to close the console app, or press any other key & Enter to continue on: ");
                if (Console.ReadLine() == "3")
                {
                    close = true;
                }

            }
        }
    }
}
