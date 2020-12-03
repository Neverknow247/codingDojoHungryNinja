using System;
using System.Collections.Generic;

namespace hungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja nathan = new Ninja();
            Buffet meal = new Buffet();
            nathan.Eat(meal.Serve());
            nathan.Eat(meal.Serve());
            nathan.Eat(meal.Serve());

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
            Food food = Menu[rand.Next(0,Menu.Count)];
            return food;
        }
    }

    class Ninja
    {
        private int calorieIntake;
        public bool isFull{
            get{
                if (calorieIntake >= 1200){
                    return true;
                }
                else{
                    return false;
                }
            }
        }
        public List<Food> FoodHistory = new List<Food>();

        public Ninja(){
            calorieIntake = 0;
        }

        // add a public "getter" property called "IsFull"

        // build out the Eat method
        public void Eat(Food item)
        {
            if(!isFull){
                this.calorieIntake+=item.Calories;
                FoodHistory.Add(item);
                if(item.IsSpicy && item.IsSweet){
                    Console.WriteLine($"The Ninja ate {item.Name} which was Spicy Sweet!");
                }
                else if(item.IsSpicy){
                    Console.WriteLine($"The Ninja ate {item.Name} which was Spicy!");
                }
                else if (item.IsSweet){
                    Console.WriteLine($"The Ninja ate {item.Name} which was Sweet!");
                }
                else{
                    Console.WriteLine($"The Ninja ate {item.Name} which was not Spicy or Sweet!");
                }

            }
            else{
                Console.WriteLine("WARNING! The ninja is full and cannot eat anymore!");
            }
        }
    }
}
