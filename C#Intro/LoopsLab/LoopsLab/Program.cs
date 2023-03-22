namespace LoopsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops");

            // For Loops
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

            // Task 6 - Fizz Buzz
            for (int i = 0; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // While Loops
            // Task 7 - Five Hellos
            bool condition = true;
            int counter = 0;
            while (condition)
            {
                if (counter < 5)
                {
                    Console.WriteLine("Hello");
                    counter += 1;    // could also do counter++

                }
                else
                {
                    condition = false;
                }
            }

            // Task 8 - Validation
            string userPassword = "password";
            string userPasswordInput;
            do
            {
                Console.WriteLine("Please enter your password:");
                userPasswordInput = Console.ReadLine();
            } while (userPassword != userPasswordInput); 
            {
                Console.WriteLine("User Validated");
            }



        }
    }
}