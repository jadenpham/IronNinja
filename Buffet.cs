using System;
using System.Collections.Generic;

namespace IronNinja2
{
    class Buffet
    {
        List<IConsumerable> FoodMenu;
        List<IConsumerable> DrinkMenu;

        public Buffet()
        {
            FoodMenu = new List<IConsumerable>()
            {
                new Food("Rice", 400, false, false),
                new Food("Noodle", 500, false, false),
                new Food("Pho", 800, false, false),
                new Food("Ramen", 900, false, false),
                new Food("Kbbq", 1500, false, false),
                new Food("Sushi", 1200, false, false)
            };
            DrinkMenu = new List<IConsumerable>()
            {
                new Drink("Jameson", 400, false),
                new Drink("Henessy", 350, false),
                new Drink("Chivas", 450, false),
                new Drink("Macallan", 380, false),
                new Drink("Patron", 300, false),
                new Drink("Soju", 200, false),
            };
        }
        public IConsumerable ServeDrink()
        {
            Random rand = new Random();
            int randIdx = rand.Next(DrinkMenu.Count);
            return DrinkMenu[randIdx];
        }
        public IConsumerable ServeFood()
        {
            Random rand = new Random();
            int randIdx = rand.Next(FoodMenu.Count);
            return FoodMenu[randIdx];
        }
    }
}