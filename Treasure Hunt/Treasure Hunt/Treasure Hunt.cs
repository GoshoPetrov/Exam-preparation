namespace Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> loot = Console.ReadLine().Split("|").ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Yohoho!")
                {
                    break;
                }

                if (command[0] == "Loot")
                {
                    for(int i = 1; i < command.Length; i++)
                    {
                        if (!loot.Contains(command[i]))
                        {
                            loot.Insert(0, command[i]);
                        }
                    }
                }
                else if (command[0] == "Drop")
                {
                    int index = int.Parse(command[1]);

                    if (index < 0 || index >= loot.Count)
                    {

                    }
                    else
                    {
                        string num = loot[index];
                        loot.RemoveAt(index);
                        loot.Insert(loot.Count, num);
                    }
                }
                else if (command[0] == "Steal")
                {
                    List<string> stolenItems = new List<string>();

                    int count = loot.Count;

                    for(int i = 0; i < int.Parse(command[1]); i++)
                    {
                        if(i >= count)
                        {
                            break;
                        }

                        stolenItems.Add(loot[loot.Count - 1]);
                        loot.RemoveAt(loot.Count - 1);
                    }

                    stolenItems.Reverse();

                    Console.WriteLine(string.Join(", ", stolenItems));

                }

            }

            if(loot.Count <= 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double sumLenght = 0;
                double count = loot.Count;
                double averageSum = 0;

                for (int i = 0; i < loot.Count; i++)
                {
                    sumLenght += loot[i].Length;
                }

                averageSum = sumLenght / count;

                Console.WriteLine($"Average treasure gain: {averageSum:F02} pirate credits.");
            }

        }
    }
}