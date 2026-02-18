using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //List<int> values = new List<int>();

            //values.Add(0);
            //values.Add(1);

            //for (int i = 2; i < 10; i++)
            //{
            //    // this is a Fibonacci sequence
            //    values.Add(values[i - 1] + values[i - 2]);
            //    // this is multiplying our inital interger by 2
            //    //values[i] = i * 2;
            //}

            //foreach (int item in values)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //string[] strings = new string[3];
            //strings[0] = "First string";
            //strings[1] = "Second string";
            //strings[2] = "Third string";

            //foreach (string item in strings)
            //{
            //    Console.WriteLine(item);
            //}


            //List<int> intList = new List<int>();

            ////this below is Index 0
            //intList.Add(20);
            //// this is index 1
            //intList.Add(30);
            //intList.Add(23);
            //intList.Add(33);
            //Console.WriteLine(intList[0]);
            //Console.WriteLine(intList[1]);
            //Console.WriteLine(intList[2]);
            //Console.WriteLine(intList[3]);
            //Console.ReadKey();


            // lets say we want to remove some from our list
            //Console.WriteLine("removing 20 from the list");
            //intList.Remove(20);
            //Console.WriteLine(intList[0]);
            //Console.WriteLine(intList[1]);
            //Console.WriteLine("Removing at Index 1");
            //intList.RemoveAt(1);
            //Console.WriteLine(intList[0]);
            //Console.WriteLine(intList[1]);

            //Console.ReadKey();



            //int[] myArray = new int[5];
            //myArray[0] = 45;
            //myArray[1] = 34;
            //myArray[2] = 56;
            //myArray[3] = 22;
            ////myArray[5] = 145; 5 is not in the array.
            //Console.WriteLine(myArray[0]);
            //Console.WriteLine(myArray[1]);
            //Console.WriteLine(myArray[2]);
            //Console.WriteLine(myArray[3]);
            //Console.WriteLine(myArray[4]);
            //Console.ReadKey();


            bool isRunning = true;
            // create new instance of a random number generator
            Random rnd = new Random();
            int number;

            // keep running this loop while "isRunning == true"
            while (isRunning == true)
            {
                // Make the Computer store a number between 1-100
                number = rnd.Next(1, 100);

                Console.WriteLine("Guess my number within 10 turns...");

                for (int i = 0; i < 10; i++)
                {
                    int guess = int.Parse(Console.ReadLine());

                    if (guess == number)
                    {
                        Console.WriteLine("Congrats! you guessed correct!");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Lower...");
                    }
                    else
                    {
                        Console.WriteLine("Higher...");
                    }
                }

                Console.WriteLine("Would you Like to play again? (Y/N)");

                string userChoice = Console.ReadLine();
                if (userChoice == "y" || userChoice == "Y")
                    isRunning = true;
                else
                    isRunning = false;

            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        } 
    }
}
