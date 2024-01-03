using System.Xml.Linq;

namespace Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();

            int maximumHealth = int.Parse(Console.ReadLine());

            bool stalemateOrNot = false;

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Retire")
                {
                    stalemateOrNot = true;
                    break;
                }

                if (command[0] == "Fire")
                {
                    int index = int.Parse(command[1]);
                    int damage = int.Parse(command[2]);

                    if(index < 0 || index >= warShip.Count)
                    {

                    }
                    else
                    {
                        warShip[index] -= damage;

                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            break;
                        }
                    }

                }
                else if (command[0] == "Defend")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    int damage = int.Parse(command[3]);
                    bool flag = false;

                    if(startIndex < 0 || startIndex >= pirateShip.Count || endIndex < 0 || endIndex >= pirateShip.Count)
                    {

                    }
                    else
                    {
                        for(int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                flag = true;
                                break;
                            }
                        }

                        if (flag)
                        {
                            Console.WriteLine("You lost! The pirate ship has sunken.");
                            break;
                        }
                    }
                }
                else if (command[0] == "Repair")
                {
                    int index = int.Parse(command[1]);
                    int health = int.Parse(command[2]);

                    if (index < 0 || index >= pirateShip.Count)
                    {

                    }
                    else
                    {
                        pirateShip[index] += health; 
                        if (pirateShip[index] > maximumHealth)
                        {
                            pirateShip[index] = maximumHealth;
                        }
                    }
                }
                else if (command[0] == "Status")
                {
                    int count = 0;

                    for(int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < maximumHealth * 0.2)
                        {
                            count++;
                        }
                    }

                    Console.WriteLine($"{count} sections need repair.");
                }

            }

            if (stalemateOrNot)
            {
                int pirateSum = 0;
                int warSum = 0;

                for(int i = 0; i < pirateShip.Count; i++)
                {
                    pirateSum += pirateShip[i];
                }

                for (int i = 0; i < warShip.Count; i++)
                {
                    warSum += warShip[i];
                }

                Console.WriteLine($"Pirate ship status: {pirateSum}");
                Console.WriteLine($"Warship status: {warSum}");
            }

        }
    }
}