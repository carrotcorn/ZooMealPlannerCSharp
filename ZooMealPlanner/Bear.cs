using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner
{
    class Bear : Mammal
    {
        public const string FEEDING_TIME = "9AM and 3PM";
        public Bear()
        {
            Console.WriteLine("Species....");
            Console.WriteLine("****************************");

            Console.WriteLine(" 1 - Black");
            Console.WriteLine(" 2 - Polar");
            Console.Write("What Is Your selection? ");

            string selection = Console.ReadLine();

            while (!selection.Equals("1") && !selection.Equals("2"))
            {
                Console.WriteLine("Choose a valid option");
                selection = Console.ReadLine();
            }


            switch (selection)
            {
                case "1":
                    string serving1 = "berries, green vegetation, flowers, fruits, fish";
                    this.DisplayMeal(getWeight(), new Decimal(0.014), "Bear", "Black", serving1, FEEDING_TIME);
                    break;
                case "2":
                    string serving2 = "berries, fish";
                    this.DisplayMeal(getWeight(), new Decimal(0.016), "Bear", "Polar", serving2, FEEDING_TIME);
                    break;
            }
        }


    }
}
