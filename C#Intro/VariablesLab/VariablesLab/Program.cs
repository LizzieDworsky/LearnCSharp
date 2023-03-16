namespace VariablesLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myAge = 32;
            Console.WriteLine($"I am {myAge} years old");
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            string fullName = firstName + " " + lastName;
        }
    }
}