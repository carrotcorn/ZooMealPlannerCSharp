using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner.Animals
{
    class Monkey : Mammal
    {
        protected Monkey()
        {
            this.MammalType = "Monkey";
            this.FeedTime = "9am, 12pm, and 5pm";
            this.FoodPreferences = "fresh fruit, vegettables, nuts, insects, berries";
        }
    }
}
