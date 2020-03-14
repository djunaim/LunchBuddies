using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public void Eat()
        {
            // instantiate Restaurant constructor so can have access to private list of restaurants
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is in the {restaurant.Name} restaurant");
        }
        public void EatFood(string food)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is eating {food} in the {restaurant.Name}");
        }
        public void Eat(List<LunchBuddy> companions)
        {
            var resto = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at the {resto.Name} restaurant.");
            foreach (var comp in companions)
            {
                Console.WriteLine($"{comp.FirstName}");
            }
        }
        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            foreach (var friend in companions)
            {
                Console.WriteLine($"{FirstName} {LastName} is at the {restaurant.Name} ordered {food} with {friend.FirstName}");
            }
        }
    }
}
