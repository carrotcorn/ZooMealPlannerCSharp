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

            
        }

    }
}
