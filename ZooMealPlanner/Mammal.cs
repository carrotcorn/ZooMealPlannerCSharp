using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner
{
    public class Mammal
    {
        public const string INSTRUCTION = "You're going to need to keep the area secure at all times";
        public Mammal() { }

        public Decimal getWeight()
        {
            Console.WriteLine("Enter the weight in Kilograms: ");
            string weightInKG = Console.ReadLine();

            decimal animalWeight = Math.Round(Convert.ToDecimal(weightInKG), 3);

            if (animalWeight == 0 || animalWeight < 0)
            {
                Console.WriteLine("Weight has to be greater than 0. Enter the weight again: ");
                weightInKG = Console.ReadLine();
                animalWeight = Math.Round(Convert.ToDecimal(weightInKG), 3);
            }


            return animalWeight;
        }

        public void DisplayMeal(Decimal weight, Decimal serveRatio, string type, string species, string food, string feedTime)
        {

            Console.WriteLine("Meal Recommendation :");
            Console.WriteLine("********************");
            Console.WriteLine("Mammal Type: " + type);
            Console.WriteLine("Species: " + species);
            Console.WriteLine("Weight: " + weight.ToString("F") + "KG");
            Console.WriteLine("Serving type : " + (object)Math.Round(Convert.ToDecimal(weight * serveRatio), 3) + "kg " + food);
            Console.WriteLine("Instructions : " + INSTRUCTION);
            Console.WriteLine("Feeding Time : " + feedTime);
            Console.WriteLine(" ");
        }
    }
}
