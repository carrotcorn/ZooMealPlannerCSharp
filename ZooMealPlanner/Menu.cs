using System;
using System.Collections.Generic;
using System.Text;
using ZooMealPlanner.Animals;

namespace ZooMealPlanner
{
    class Menu
    {
        private const int FIRST_COLUMN_ALIGNMENT = -15;

        public static void Display()
        {
            List<Mammal> Bears = new List<Mammal>();
            Bears.Add(new BlackBear());
            Bears.Add(new PolarBear());


            List<Mammal> Monkey = new List<Mammal>();
            Monkey.Add(new Squirrel());
            Monkey.Add(new Howler());
            Monkey.Add(new Colobus());
        }


    }
}
