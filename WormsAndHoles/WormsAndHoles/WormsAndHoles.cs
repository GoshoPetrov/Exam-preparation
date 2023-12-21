namespace WormsAndHoles
{
    internal class WormsAndHoles
    {
        static void Main(string[] args)
        {
            List<int> warmSize = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> holeSize = Console.ReadLine().Split().Select(int.Parse).ToList();

            int machesCount = 0;

            int wormCount = warmSize.Count;

            while(warmSize.Count > 0 && holeSize.Count > 0)
            {
                if (warmSize[warmSize.Count - 1] <= 0)
                {
                    warmSize.RemoveAt(warmSize.Count - 1);
                }

                if (warmSize[warmSize.Count - 1] == holeSize[0])
                {
                    warmSize.RemoveAt(warmSize.Count - 1);
                    holeSize.RemoveAt(0);
                    machesCount++;
                }
                else
                {
                    holeSize.RemoveAt(0);
                    warmSize[warmSize.Count - 1] -= 3;
                }

            }

            if(machesCount > 0)
            {
                Console.WriteLine($"Matches: {machesCount}");
            }
            else
            {
                Console.WriteLine("there are no matches.");
            }

            warmSize.Reverse();

            if (warmSize.Count <= 0 && machesCount == wormCount)
            {
                Console.WriteLine($"Every worm found a suitable hole!");
            }
            else if(machesCount != wormCount && wormCount <= 0)
            {

            }
            else if(warmSize.Count > 0)
            {
                Console.WriteLine($"Worms left: {string.Join(", ", warmSize)}");
            }

            if(holeSize.Count <= 0)
            {
                Console.WriteLine($"Holes left: none");
            }
            else
            {
                Console.WriteLine($"Holes left: {string.Join(", ", holeSize)}");
            }

        }
    }
}