namespace MuOnline
{
    internal class MuOnline
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine().Split("|").ToList();

            int health = 100;
            int bitcoins = 0;
            int count = 0;

            bool flag = true;

            for(int i = 0; i < rooms.Count; i++)
            {
                List<string> command = rooms[i].Split(" ").ToList();

                count++;

                int amount = int.Parse(command[1]);

                if (command[0] == "potion")
                {
                    if(health + amount <= 100)
                    {
                        health += amount;  
                    }
                    else
                    {
                        health += amount;
                        amount = amount - (health - 100);
                        health = 100;
                    }

                    Console.WriteLine($"You healed for {amount} hp.");

                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command[0] == "chest")
                {
                    bitcoins += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                }
                else
                {
                    health -= amount;

                    if(health > 0)
                    {
                        Console.WriteLine($"You slayed {command[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command[0]}.");
                        Console.WriteLine($"Best room: {count}");
                        flag = false;
                        break;
                    }

                }

            }

            if (flag)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }

        }
    }
}