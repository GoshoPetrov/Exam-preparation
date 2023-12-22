namespace Monster_Extermination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> armor = Console.ReadLine().Split(",").Select(int.Parse).ToList();
            List<int> strenght = Console.ReadLine().Split(",").Select(int.Parse).ToList();

            int safe = 0;

            int monstersKilled = 0;

            while(armor.Count > 0 && strenght.Count > 0)
            {

                if (strenght[strenght.Count - 1] >= armor[0])
                {
                    strenght[strenght.Count - 1] -= armor[0];
                    armor.RemoveAt(0);
                    strenght[strenght.Count - 2] += strenght[strenght.Count - 1];
                    strenght.RemoveAt(strenght.Count - 1);
                    monstersKilled++;
                }
                else
                {
                    armor[0] -= strenght[strenght.Count - 1];
                    strenght.RemoveAt(strenght.Count - 1);
                    //armor[armor.Count - 1] = armor[0];
                    armor.Insert(armor.Count - 1, armor[armor.Count - 1]);
                    armor.RemoveAt(0);
                }

            }

            if(armor.Count <= 0)
            {
                Console.WriteLine($"All monsters have been killed!");
            }
            else if(strenght.Count <= 0)
            {
                Console.WriteLine("The solfier has been defeated.");
            }

            Console.WriteLine($"Total monsters killed: {monstersKilled}");
        }
    }
}