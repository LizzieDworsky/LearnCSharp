namespace ProblemSolvingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Task 1: Reverse a string
            //    Algorithm:
            //    1. need to get user input, a string to reverse
            //    2. need the length of the string
            //    3. create a variable that will be the reversed string
            //    4. use the length to get the starting place
            //    5. step backwards from the end and add to the reversed string variable

            Console.WriteLine("Please enter a string for reversal:");
            string userInputOne = Console.ReadLine();
            string reversedString = "";
            for (int i = userInputOne.Length - 1; i > -1; i--)
            {
                reversedString += userInputOne[i];
            }
            Console.WriteLine(reversedString);


            //Task 2: Capitalize Last Letter
            //    Algorithm:
            //    1. need to get user input, a string to capitalize
            //    2. need the length of the string
            //    3. iterate through the string
            //    4. use the length to capitalize the final index letter
            //    5. use any spaces to capitalize the last letter of the words

            Console.WriteLine("Please enter a string for capitolizatioN:");
            string userInputTwo = Console.ReadLine();
            string capitolLastLetter = "";
            for (int i = 0; i < userInputTwo.Length; i++)
            {
                if (i == userInputTwo.Length - 1 || Char.IsWhiteSpace(userInputTwo, i + 1) || userInputTwo[i + 1] == ' ')
                {
                    capitolLastLetter += char.ToUpper(userInputTwo[i]);
                }
                else
                {
                    capitolLastLetter += userInputTwo[i];
                }
            }
            Console.WriteLine(capitolLastLetter);


            //Task 3: Palindrome
            //    Algorithm:
            //    1. need user input, a string to check
            //    2. going to use the previous reverse string code to get a reversed version of user input
            //    3. compare the two strings, original and reversed
            //    4. if equal, palindrome ✅ otherwise ❎

            Console.WriteLine("Enter a string to see if it a Palindrome:");
            string userInputThree = Console.ReadLine();
            string reversedInputThree = "";
            for (int i = userInputThree.Length - 1; i > -1; i--)
            {
                reversedInputThree += userInputThree[i];
            }
            if (reversedInputThree == userInputThree)
            {
                Console.WriteLine("Palindrome!");
            }
            else
            {
                Console.WriteLine("Not a Palindrome!");
            }


            //Task 4: Compress a string of characters
            //    Algorithm:
            //    1. create string for compression
            //    2. need the length of the string
            //    3. use the length to iterate through the string
            //    4. create an empty string to capture the compressed string
            //    5. create a counter
            //    6. capture the first character of the string (at index 0) in a variable
            //    7. compare the characters, starting with the first one
            //    8. if they match add to counter
            //    9. if they don't reset counter and change variable for comparison to that character
            //    after adding the counter and current character to the compression string

            string compressionString = "aaabbbbbccccaacccbbbaaabbbaaa";
            string compressedString = "";
            char currentCharacter = compressionString[0];
            int counter = 0;
            for (int i = 0; i < compressionString.Length; i++)
            {
                if (currentCharacter == compressionString[i])
                {
                    counter += 1;
                }
                else
                {
                    compressedString += $"{counter}{currentCharacter}";
                    counter = 1;
                    currentCharacter = compressionString[i];
                }
            }
            compressedString += $"{counter}{currentCharacter}";
            Console.WriteLine(compressedString);

        }
    }
}