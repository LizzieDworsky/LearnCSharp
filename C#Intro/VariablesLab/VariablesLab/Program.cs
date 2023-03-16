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
            Console.WriteLine($"My first name is {firstName} and my last name is {lastName}, which means my full name is {fullName}");

            double fahrenTemp = 45.6;
            double celcTemp = (fahrenTemp - 32) * .5556;
            celcTemp = Math.Round((Double)celcTemp, 2);
            Console.WriteLine($"{fahrenTemp} degrees fahrenheit is {celcTemp} degrees celsius");
        }
    }
}