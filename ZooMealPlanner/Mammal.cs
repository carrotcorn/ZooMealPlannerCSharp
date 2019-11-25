using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner
{
    internal class Mammal
    {
        public Decimal GetWeight()
        {
            Console.Write("Weight In KG: ");
            var weightKg = Console.ReadLine();
            double result;
            if (!double.TryParse(weightKg, out result))
            {
                Console.WriteLine("Invalid");
                Console.WriteLine();
                this.GetWeight();
            }
            else if (Convert.ToDouble(weightKg) < 0.0)
            {
                Console.WriteLine("Nothing can weight less than 0");
                Console.WriteLine();
                this.GetWeight();
            }
            return Math.Round(Convert.ToDecimal(weightKg), 2);

        }

        public void MealRecommendation(
          Decimal weight,
          Decimal servingRatio,
          string servings,
          string feedingTime)
        {
           
            Console.WriteLine("Meal size and serving recommendation");
            Console.WriteLine("*******************");
            Console.WriteLine("Mammal Type: ");
            Console.WriteLine("Breed: ");
            Console.WriteLine("Weight:    " + weight.ToString("F") + " KG");
            Console.WriteLine("Serving:   " + (object)(Math.Round(Convert.ToDecimal(weight), 2) * servingRatio) + " KG " + servings);
            Console.WriteLine("Instructions: Keep area secure at all times.");
            Console.WriteLine("  Feed at " + feedingTime);
        }
    }
}
