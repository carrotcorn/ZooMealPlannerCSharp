using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner.Animals
{
    class Bear : Mammal
    {
        protected Bear()
        {
            this.MammalType = "Bear";
            this.FeedTime = "9am and 3pm";
        }
    }
}
