using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner.Animals
{
    abstract class Mammal
    {
        public string MammalType { get; set; }
        public string Species { get; set; }
        public decimal ServingWeightRatio { get; set; }
        public string FoodPreferences { get; set; }
        public string FeedTime { get; set; }

    }

}
