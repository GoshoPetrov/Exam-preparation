namespace Meal_Plan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> meals = Console.ReadLine().Split().ToList();
            List<int> calories = Console.ReadLine().Split().Select(int.Parse).ToList();

            int safe = 0;

            int countMeals = 0;

            while(meals.Count > 0 && calories.Count > 0)
            {
                if (meals[0] == "salad")
                {
                    calories[calories.Count - 1] -= 350;
                    safe = calories[calories.Count - 1];
                    meals.RemoveAt(0);
                    countMeals++;
                }
                else if (meals[0] == "soup")
                {
                    calories[calories.Count - 1] -= 490;
                    safe = calories[calories.Count - 1];
                    meals.RemoveAt(0);
                    countMeals++;
                }
                else if (meals[0] == "pasta")
                {
                    calories[calories.Count - 1] -= 680;
                    safe = calories[calories.Count - 1];
                    meals.RemoveAt(0);
                    countMeals++;
                }
                else if (meals[0] == "steak")
                {
                    calories[calories.Count - 1] -= 790;
                    safe = calories[calories.Count - 1];
                    meals.RemoveAt(0);
                    countMeals++;
                }

                if (calories[calories.Count - 1] <= 0)
                {
                    calories.RemoveAt(calories.Count - 1);
                    if(calories.Count > 0)
                    {
                        calories[calories.Count - 1] += safe;
                    }
                }
            }

            if(meals.Count <= 0)
            {
                Console.WriteLine($"John had {countMeals} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calories)} calories.");
            }
            else if(calories.Count <= 0)
            {
                Console.WriteLine($"John ate enough, he had {meals.Count} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meals)}");
            }

        }
    }
}