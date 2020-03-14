using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {

            List<LunchBuddy> companions = new List<LunchBuddy> { };

            companions.Add(new LunchBuddy("Poo", "Poo"));
            companions.Add(new LunchBuddy("Shoo", "Fly"));
            companions.Add(new LunchBuddy("Peter", "Pan"));

            var lunchBuddy = new LunchBuddy("Po", "Do");
            var resto = new Restaurant();


            lunchBuddy.Eat();
            lunchBuddy.EatFood("sandwich");
            lunchBuddy.Eat(companions);
            lunchBuddy.Eat("hamburgers", companions);
            // below code to make sure getting random restaurants
            //Console.WriteLine(resto.Name);
            //Console.ReadLine();
        }
    }
}
