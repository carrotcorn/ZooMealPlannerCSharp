using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner
{
    class Monkey : Mammal
    {
        public const string FEEDING_TIME = "9AM, 12PM and 5PM.";
        public const string SERVING_TYPE = "fruit, vegetables, nuts, insects, berries";
        public Monkey()
        {
            Console.WriteLine("Species...");
            Console.WriteLine("*********************");

            Console.WriteLine(" 1 - Squirrel");
            Console.WriteLine(" 2 - Howler");
            Console.WriteLine(" 3 - Colobus");
            Console.Write("What is your selection? ");

            string selection = Console.ReadLine();

            while (!selection.Equals("1") && !selection.Equals("2") && !selection.Equals("3"))
            {
                Console.WriteLine("Please choose a valid option");
                selection = Console.ReadLine();
            }


            switch (selection)
            {
                case "1":
                    this.DisplayMeal(getWeight(), new Decimal(0.006), "Monkey", " Squirrel", SERVING_TYPE, FEEDING_TIME);
                    break;
                case "2":
                    this.DisplayMeal(getWeight(), new Decimal(0.007), "Monkey", "Howler", SERVING_TYPE, FEEDING_TIME);
                    break;
                case "3":
                    this.DisplayMeal(getWeight(), new Decimal(0.008), "Monkey", "Colobus", SERVING_TYPE, FEEDING_TIME);
                    break;
            }

        }

    }
}
