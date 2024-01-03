namespace Inventory
{
    internal class Inventory
    {
        static void Main(string[] args)
        {

            List<string> journal = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split("-:".ToCharArray(), 
                    StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Craft!")
                {
                    Console.WriteLine(string.Join(", ", journal));
                    break;
                }

                if (command[0] == "Collect")
                {
                    if (journal.Contains(command[1]))
                    {

                    }
                    else
                    {
                        journal.Add(command[1]);
                    }
                }
                else if (command[0] == "Drop")
                {
                    if (journal.Contains(command[1]))
                    {
                        journal.Remove(command[1]);
                    }
                }
                else if (command[0] == "Combine Items")
                {
                    if (journal.Contains(command[1]))
                    {
                        journal.Insert(journal.IndexOf(command[1]) + 1, command[2]);
                    }
                }
                else if (command[0] == "Renew")
                {
                    if (journal.Contains(command[1]))
                    {
                        journal.Remove(command[1]);
                        journal.Insert(journal.Count, command[1]);
                    }
                }

            }
        }
    }
}