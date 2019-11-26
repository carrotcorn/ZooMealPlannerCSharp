﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner
{
    public class Mammal
    {
        public const string INSTRUCTION = "You're going to need tot keep the area secure at all times";
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

        
    }
}
