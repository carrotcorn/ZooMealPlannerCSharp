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

        }


    }
}
