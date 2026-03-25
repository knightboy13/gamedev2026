using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ICTPRG302_Intro_to_Programming
{
	class Program
	{
		/// <summary>
		/// This is the starting location for the program.
		/// </summary>
		/// <param name="args">
		/// A list of strings passed in to the program
		/// from the command-line when it was started
		/// </param>
		static void Main(string[] args)
		{
			Gamertags gamertags = new Gamertags();
            gamertags.LoadGamerTags();


            bool isRunning = true;

			while (isRunning)
			{
				Console.WriteLine("*** Program sequence output - display gamertags etc.. ***");

                gamertags.Introduction();
				gamertags.CreateNewTag();
                gamertags.PrintAllGamertags();
                gamertags.PrintGamertagsEndingWithNumber();
                gamertags.PrintGamertagsNotStartingWithLetterOrDigit();

                Console.WriteLine("would you like to view the gamertags again? (Y/N)");

				if (Console.ReadKey().Key == ConsoleKey.Y)
					isRunning = true;
				else
					isRunning = false;
			}

			
			
		
			
		}
	}
}
