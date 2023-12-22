using System.Reflection;

namespace Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "End")
                {
                    Console.WriteLine(string.Join("|", nums));
                    break;
                }

                if (command[0] == "Shoot")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= nums.Count - 1)
                    {
                        nums[int.Parse(command[1])] -= int.Parse(command[2]); 

                        if(nums[int.Parse(command[1])] <= 0)
                        {
                            nums.RemoveAt(int.Parse(command[1]));
                        }
                    }
                }
                else if (command[0] == "Add")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= nums.Count - 1)
                    {
                        nums.Insert(int.Parse(command[1]), int.Parse(command[2]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command[0] == "Strike")
                {
                    int index = int.Parse(command[1]);
                    int r = int.Parse(command[2]);

                    int startIndex = index - r;
                    int endIndex = index + r;
                    int countToRemove = 2 * r + 1;

                    if (!(startIndex >= 0 && startIndex < nums.Count)
                        || !(endIndex >= 0 && endIndex < nums.Count))
                    {
                        Console.WriteLine("Strike missed!");
                    } 
                    else
                    {
                        for (int i = 0; i < countToRemove; i++)
                        {
                            nums.RemoveAt(startIndex);
                        }
                    }


                }

            }
        }
    }
}