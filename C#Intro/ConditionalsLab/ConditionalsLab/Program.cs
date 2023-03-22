namespace ConditionalsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");

            // Task one - Driving
            int legalDrivingAge = 16;
            Console.WriteLine("What is your age?");
            int userInputAge = int.Parse(Console.ReadLine());   // can use TryParse instead to handle the error
            if (legalDrivingAge <= userInputAge)
            {
                Console.WriteLine("You are legally able to drive");
            } else
            {
                Console.WriteLine("You are not able to drive yet");
            }

            // Task two - Random
            Random rand = new Random();   // will not hoist
            int randNumber = rand.Next(11);
            if (randNumber >= 0 && randNumber <= 2)
            {
                Console.WriteLine("0 or 1 or 2");
            } else if (randNumber >= 3 && randNumber <= 5)
            {
                Console.WriteLine("3 or 4 or 5");
            } else if (randNumber >= 6 && randNumber <= 8)
            {
                Console.WriteLine("6 or 7 or 8");
            } else if (randNumber == 9 || randNumber == 10)
            {
                Console.WriteLine("9 or 10");
            }

            // Task three
            Console.WriteLine("Enter an NFL team name");
            string footballTeamName = Console.ReadLine();
            switch(footballTeamName)
            {
                case "Bears":
                    Console.WriteLine("Dan's favorite team!");
                    break;
                case "49ers":
                    Console.WriteLine("Amy's favorite team!");
                    break;
                case "Raiders":
                    Console.WriteLine("Sarah's favorite team!");
                    break;
                default:
                    Console.WriteLine("Is that an NFL team?");
                    break;
            }
        }
    }
}