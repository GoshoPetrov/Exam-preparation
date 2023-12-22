namespace Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double lectures = int.Parse(Console.ReadLine());
            double bonus = int.Parse(Console.ReadLine());

            int biggestAttendence = int.MinValue;
            double biggestBonus = int.MinValue;

            double totalBonus = 0;

            for (int i = 0; i < students; i++)
            {
                int attendace = int.Parse(Console.ReadLine());

                if (attendace > biggestAttendence)
                {
                    biggestAttendence = attendace;
                }

                totalBonus = Math.Ceiling((attendace / lectures) * (5 + bonus));

                if (totalBonus > biggestBonus)
                {
                    biggestBonus = totalBonus;
                }

            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(biggestBonus)}.");
            Console.WriteLine($"The student has attended {biggestAttendence} lectures.");

        }
    }
}