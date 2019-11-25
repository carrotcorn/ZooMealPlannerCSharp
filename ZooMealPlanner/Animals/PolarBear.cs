using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner.Animals
{
    class PolarBear : Bear
    {
        public PolarBear() : base()
        {
            this.Species = "Polar";
            this.ServingWeightRatio = 0.016m;
            this.FoodPreferences = "fish and berries";

        }
    }
}

