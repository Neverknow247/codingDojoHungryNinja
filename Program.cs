using System;
using System.Collections.Generic;

namespace hungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string name, int cal, bool spicy, bool sweet){
            Name = name;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }

    class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
        {
            new Food("Eggs", 1000, false, false),
            new Food("Bacon", 2000, true, false),
            new Food("Ham", 1200, false, true),
            new Food("Sausage", 1800, true, true),
            new Food("Toast", 500, false, false),
            new Food("Biscuits", 900, false, false),
            new Food("Pancakes", 1300, false, true)
        };
        }

        public Food Serve()
        {
            Random rand = new Random();
            Food food = Menu[rand.Next(0,6)];
            return food;
        }
    }

    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        // add a constructor

        // add a public "getter" property called "IsFull"

        // build out the Eat method
        public void Eat(Food item)
        {
        }
    }






}
