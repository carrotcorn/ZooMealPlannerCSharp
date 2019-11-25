using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner
{
    internal sealed class Menu
    {
        private Canine Wolf = new Canine();
        private Feline Tiger = new Feline();

        public string GetMealPlan()
        {
            Console.WriteLine();
            Console.WriteLine("****************");
            Console.WriteLine("Zoo Menu Planner");
            Console.WriteLine("****************");
            
        }
    }
}
