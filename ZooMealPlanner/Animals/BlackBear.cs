using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner.Animals
{
    class BlackBear : Bear
    {
        public BlackBear() : base()
        {
            this.Species = "Black Bear";
            this.ServingWeightRatio = 0.014m;
            this.FoodPreferences = "berries, green vegetation, flowers, fruits, fish";
        }
    }
}
