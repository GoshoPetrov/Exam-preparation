namespace Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int wonBattles = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End of battle")
                {
                    Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
                    break;
                }
                int distance = int.Parse(command);

                if (distance > energy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    break;
                }

                energy -= distance;
                wonBattles++;
                if (wonBattles % 3 == 0)
                {
                    energy += wonBattles;
                }

            }
        }
    }
}