using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ICTPRG302_Intro_to_Programming
{
    class Gamertags
    {

        public void Introduction()
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("Welcome to the Gamertag Database");
            Console.WriteLine("========================");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }



        // The list of gamer tags loaded from file
        private List<string> gamerTagList = new List<string>();

        // Load a list of gamertags from file and store the resulting list in our gamerTagList
        public void LoadGamerTags()
        {
            gamerTagList = File.ReadAllLines("../Gamertags.txt").ToList(); 
        }

        // Display all gamertags on the console
        public void PrintAllGamertags()
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("All Gamertags");
            Console.WriteLine("========================");

            // Loop over the list of gamertags and print each out on a new line
            int lineNumber = 1;  // this local variable is used as a "bullet list" counter for each line
            foreach (string s in gamerTagList)
            {
                // Format a line for each gamertag with a number in front
                // Note: There are alternative memory-efficent methods to concatenate strings
                Console.WriteLine(lineNumber.ToString() + ") " + s);

                lineNumber = lineNumber + 1;    // Increment the lineNumber for the next time around the loop
            }

            // Display a message to the user & wait for a keypress
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

           
        }

        // Display gamertags ending with a number
        public void PrintGamertagsEndingWithNumber()
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("Gamertags ending with a number.");
            Console.WriteLine("========================");

            // Loop over the list of gamertags and print each out on a new line
            int lineNumber = 1; // this local variable is used as a "bullet list" counter for each line
            foreach (string s in gamerTagList)
            {
                // Test each gamertag to unsure that it has at least one character, AND the last character in is a number
                // If both tests pass, then the "if" statement's body will execute
                if ((s.Length > 0) && Char.IsNumber(s, s.Length - 1))
                {
                    // Format a line for each gamertag with a number in front
                    // Note: There are alternative memory-efficent methods to concatenate strings
                    Console.WriteLine(lineNumber.ToString() + ") " + s);

                    lineNumber = lineNumber + 1;     // Incerment the lineNumber for the next time around the loop
                }
            }

            // Display a message to the user & wait for a keypress
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        // Display gamertags Not starting with a letter or number

        public void PrintGamertagsNotStartingWithLetterOrDigit()
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("Gamertags NOT starting with a letter or digit.");
            Console.WriteLine("========================");

            // Loop over the list of gamertags and print each out on a new line
            int lineNumber = 1; // this local variable is used as a "bullet list" counter for each line
            foreach (string currentTag in gamerTagList)
            {
                // Test each gamertag to unsure that it has at least one character, AND the last character in is a number
                // If both tests pass, then the "if" statement's body will execute
                if ((currentTag.Length > 0) && Char.IsLetterOrDigit(currentTag, 0) == false)
                {
                    // Format a line for each gamertag with a number in front
                    // Note: There are alternative memory-efficent methods to concatenate strings
                    Console.WriteLine(lineNumber.ToString() + ") " + currentTag);

                    lineNumber = lineNumber + 1;     // Incerment the lineNumber for the next time around the loop
                }
            }

            // Display a message to the user & wait for a keypress
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

        public void CreateNewTag()
        {
            //Ask for new tag
            Console.WriteLine("Do you want to add a new tag to the list? (Y/N)");
            ConsoleKey input = Console.ReadKey().Key;

            // Get new tag
            if (input != ConsoleKey.Y)
            {
                return;
            }

            Console.WriteLine("Add in new tag:");
            //Store new name
            string newTag = Console.ReadLine();
            // Add to the list
            gamerTagList.Add(newTag);

            File.WriteAllLines("../Gamertags.txt", gamerTagList);

        }


    }
}
