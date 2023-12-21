namespace Flower_Wreaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lilies = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            List<int> roses = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            int sum = 0;
            double count = 0;

            double sumStored = 0;

            while(lilies.Count > 0 && roses.Count > 0)
            {
                sum = lilies[lilies.Count - 1] + roses[0];
                
                if(sum == 15)
                {
                    lilies.RemoveAt(lilies.Count - 1);
                    roses.RemoveAt(0);
                    count++;
                }
                else if(sum > 15)
                {
                    roses[0] -= 2;
                }
                else
                {
                    sumStored += roses[0] + lilies[lilies.Count - 1];
                    lilies.RemoveAt(lilies.Count - 1);
                    roses.RemoveAt(0);
                }
            }

            count += Math.Floor(sumStored / 15);

            if(count >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {count} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - count} wreaths more!");
            }
        }
    }
}