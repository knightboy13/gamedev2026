using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersToSort = { 3, 53, 6, 34, 8, 45, 2, 7 };
            // minus one is to help the pc check that if there are no more numbers to compare to, it is done.
            for (int j = 0; j < numbersToSort.Length - 1; j++)
            { 
                for (int i = 0; i < numbersToSort.Length - j - 1; i++)
                {
                    // is the left bigger than the right.
                    if (numbersToSort[i] > numbersToSort[i + 1])
                    {
                        int temp = numbersToSort[i];
                        numbersToSort[i] = numbersToSort[i + 1];
                        numbersToSort[i + 1] = temp;
                    }

                }
            }

            for (int i = 0; i < numbersToSort.Length; i++)
            {
                Console.Write(numbersToSort[i] + " ");
            }



            //bool isRunning = true;

            //string[] userNames = { "Bill", "Ted", "Spock" };

            //while(isRunning == true)
            //{
            //    string name = Console.ReadLine();

            //    bool usernamecorrect = false;

            //    for (int i = 0; i < userNames.Length; i++)
            //    {

            //        if (name == userNames[i])
            //        {
            //            Console.WriteLine("Welcome " + name + " Please enter");
            //            usernamecorrect = true;
            //            isRunning = false;
            //            break; //Exit the loop
            //        }

            //    }

            //    if (usernamecorrect == false)
            //    {
            //        Console.WriteLine("Incorrect Username. Try Again");

            //    }
            //}

           
        }
    }
}
