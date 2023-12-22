namespace Offroad_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> fuel = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> consumption = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> reach = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> memory = new List<string>();

            int sum = 0;

            int count = 0;

            bool flag = false;

            for(int i = 0; i < 4; i++)
            {
                sum = fuel[fuel.Count - 1] - consumption[0];

                count++;

                if (sum >= reach[0])
                {
                    memory.Add($"Altitute {count}");

                    fuel.RemoveAt(fuel.Count - 1);
                    consumption.RemoveAt(0);
                    reach.RemoveAt(0);

                    Console.WriteLine($"Johon has reached: Altitude {count}");
                }
                else
                {
                    flag = true;
                    Console.WriteLine($"John did not reach: Altitude {count}");
                    break;
                }
            }

            if(flag && count > 0)
            {
                Console.WriteLine($"John failed to reach the top.");
                Console.WriteLine($"Reached altitudes: {string.Join(", ", memory)}"); 
            }
            else if (flag)
            {
                Console.WriteLine($"Jhon failed to reach the top.");
                Console.WriteLine($"Jhon didn't reach the altitude.");
            }
            else
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }

        }
    }
}