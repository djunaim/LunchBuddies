using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        private List<string> _restaurantNames = new List<string> { "Popeyes", "Olive Garden", "Pizza Hut" };
        public string Name { get; set; }

        public Restaurant()
        {
            Random rnd = new Random();

            int restoNum = rnd.Next(3);
            Name = _restaurantNames[restoNum];
        }
    }
}
