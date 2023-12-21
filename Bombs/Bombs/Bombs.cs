using System.Runtime.InteropServices;

namespace Bombs
{
    internal class Bombs
    {
        static void Main(string[] args)
        {
            List<int> bombEffect = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            List<int> bombCasing = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            int sum = 0;

            int DaturaBombs = 0;
            int CherryBombs = 0;
            int SmokeDecoyBombs = 0;

            bool flag = false;

            while (bombEffect.Count > 0)
            {
                sum = bombEffect[0] + bombCasing[bombCasing.Count - 1];

                if(sum == 40)
                {
                    bombEffect.RemoveAt(0);
                    bombCasing.RemoveAt(bombCasing.Count - 1);
                    DaturaBombs++;
                }
                else if (sum == 60)
                {
                    bombEffect.RemoveAt(0);
                    bombCasing.RemoveAt(bombCasing.Count - 1);
                    CherryBombs++;
                }
                else if (sum == 120)
                {
                    bombEffect.RemoveAt(0);
                    bombCasing.RemoveAt(bombCasing.Count - 1);
                    SmokeDecoyBombs++;
                }
                else
                {
                    bombCasing[bombCasing.Count - 1] -= 5;
                }

                if (DaturaBombs >= 3 && CherryBombs >= 3 && SmokeDecoyBombs >= 3)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You dont have enough materials to fill the bomb pouch.");
            }

            if(bombEffect.Count > 0)
            {
                Console.WriteLine(string.Join(", ", bombEffect));
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (bombCasing.Count > 0)
            {
                Console.WriteLine(string.Join(", ", bombCasing));
            }
            else
            {
                Console.WriteLine("Bomb Casing: empty");
            }

            Console.WriteLine($"Cherry Bombs: {CherryBombs}");
            Console.WriteLine($"Datura Bombs: {DaturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {SmokeDecoyBombs}");
        }
    }
}