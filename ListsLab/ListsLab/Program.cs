namespace ListsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lists Lab");

            // Task 1: Accessing a value
            List<string> programLangAndFrame = new List<string>
            {
                "C#",
                "JavaScript",
                "Python",
                "Java",
                "ASP.NET",
                "React"
            };
            Console.WriteLine(programLangAndFrame[1]);

            // Task 2: Adding and Changing Values
            List<string> teamNames = new List<string>
            {
                "Mike",
                "Nevin",
                "Jake",
                "Dan",
                "Megan"
            };
            teamNames.Add("Dan");
            teamNames.Add("Amy");
            teamNames.Add("Ted");
            teamNames[3] = "Danimal";

            foreach (string name in teamNames)
            {
                Console.WriteLine(name);
            }

            // Task 3: Removing a value
            teamNames.Remove("Ted");
            for (int i = 0; i < teamNames.Count; i++)
            {
                Console.WriteLine(teamNames[i]);
            }

            // Task 4: Removing by Index
            teamNames.RemoveAt(0);
            Console.WriteLine(teamNames.Count);

            // Task 5a: Looping over Lists
            List<string> names = new List<string>
            {
                "John",
                "Thomp",
                "Sander",
                "Robin"
            };
            for (int i = 0; i < names.Count; i++)
            {
                names[i] = names[i] + "son";
                Console.WriteLine(names[i]);
            }

            // Task 5b: Looping over Lists
            List<string> compoundWordsPartOne = new List<string>
            {
                "fan",
                "bull-",
                "high-",
                "barrel-o-",
                "slap"
            };
            List<string> compoundWordsPartTwo = new List<string>
            {
                "dango",
                "rider",
                "horse",
                "monkeys",
                "stick"
            };
            for (int i = 0; i < compoundWordsPartOne.Count; i++)
            {
                string tempString = compoundWordsPartOne[i] + compoundWordsPartTwo[i];
                Console.WriteLine(tempString);
            }

            // Task 6: Checking Values
            string newName = "Josh";
            bool duplicateFound = false;
            foreach (string name in teamNames)
            {
                if (newName == name)
                {
                    duplicateFound = true;
                }
            }
            if (duplicateFound)
            {
                Console.WriteLine("Sorry that name has been taken, please provide a nickname.");
            }
            else
            {
                teamNames.Add(newName);
            }
        }
    }
}