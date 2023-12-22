using System.Globalization;

namespace Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int count = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if(command == "End")
                {
                    break;
                }

                int index = int.Parse(command);

                if(index > nums.Count - 1)
                {
                    continue;
                }

                count++;

                if (nums[index] != -1)
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (i == index)
                        {
                            continue;
                        }

                        if (nums[i] != -1)
                        {
                            if (nums[i] > nums[index])
                            {
                                nums[i] -= nums[index];
                            }
                            else
                            {
                                nums[i] += nums[index];
                            }
                        }

                    }

                    nums[index] = -1;
                }

                
            }

            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", nums)}");
        }
    }
}