using System;
using System.Collections.Generic;

namespace IronNinja2
{
    class Food : IConsumerable
    {
        //implemented classes have to satisfy interface's members and methods
        public string Name {get; set;}
        public int Calories {get; set;}
        public bool Spicy {get; set;}
        public bool Sweet {get; set;}
        public string GetInfo()
        {
            return $"Food: {Name}. Calories: {Calories}. Spicy: {Spicy}. Sweet: {Sweet}";
        }
        //constructor
        public Food(string name, int cal, bool spicy, bool sweet)
        {
            Name = name;
            Calories = cal;
            Spicy = spicy;
            Sweet = sweet;
        }
    }

    class Drink : IConsumerable
    {
        public string Name {get; set;}
        public int Calories {get; set;}
        public bool Spicy {get; set;}
        public bool Sweet {get; set;}
        public string GetInfo()
        {
            System.Console.WriteLine($"Drink: {Name}. Calories: {Calories}. Spicy: {Spicy}. Sweet: {Sweet}");
            return $"Drink: {Name}. Calories: {Calories}. Spicy: {Spicy}. Sweet: {Sweet}";
        }
        public Drink(string name, int cal, bool spicy)
        {
            Name = name;
            Calories = cal;
            Sweet = true;
            Spicy = spicy;
        }
    }
}