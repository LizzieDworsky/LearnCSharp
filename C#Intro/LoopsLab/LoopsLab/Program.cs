namespace LoopsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops");

            // Task 1 - Five Hellos
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello");
            }

            // Task 2 - Count
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            // Task 3 - Count Backwards
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            // Task 4 - Prompt Output
            Console.WriteLine("How many times would you like to print devCodeCamp?");
            int userInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine("devCodeCamp");
            }

            // Task 5 - String out a String
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            foreach (char letter in str)
            {
                Console.WriteLine(letter);
            }



        }
    }
}