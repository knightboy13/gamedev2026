using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_week_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SimpleCalculator();
        }

        static void StringExercise()
        {
            string firstName = "";
            string lastName = "";

            firstName = "Anton";
            lastName = "Ferrise";
            // the tideous way.
            string fullName = firstName + " " + lastName;

            // the programer way part 1
            fullName = $"{firstName} + {lastName}";

            // part 2 - can do more with formatting later
            fullName = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine("Hello! " + fullName + " Stay a while and listen.");
            Console.WriteLine($"You Have a {fullName[3]} As the fourth character");
        }

        static void OperatorExercise()
        {
            int calculation = 1 + 2;
            Console.WriteLine("what is 1 + 2?");
            Console.ReadLine();

            Console.WriteLine("1 + 2 = " + calculation + " !");


        }

        static void IfExercise()
        {
            int playerHealth = 100;
            int monsterDamage = 90;
            playerHealth -= monsterDamage;

            if(playerHealth < 0)
            {
                playerHealth = 0;
            }

            Console.WriteLine("A monster attacked you and did " + monsterDamage + " damage, you have " + playerHealth + " left");
            if(playerHealth <= 0)
            {
                Console.WriteLine("You died! Game over");
 
            }
            else if(playerHealth > 0)
            {
                Console.WriteLine("The monster prepares to attack you again.");
            }

            else if(monsterDamage < 50)
            {
                Console.WriteLine("The monster is very strong.");
            }
                Console.ReadKey();
        }

        static void SimpleCalculator()
        {
            float number1;
            float number2;
            string userOperation;

            Console.WriteLine("Enter first number.");
            bool success = float.TryParse(Console.ReadLine(), out number1);
            if (success == false)
            {
                Console.WriteLine("Error: Not a number. Setting to 0");
                number1 = 0;
            }
            
            //number1 = float.Parse();

            Console.WriteLine("Enter second number");
            success = float.TryParse(Console.ReadLine(), out number2);
            if (success == false)
            {
                Console.WriteLine("Error: not a number. setting to 0");
                number2 = 0;
            }

            Console.WriteLine("Enter operation: + - / *");
            userOperation = Console.ReadLine();

            float result = 0;

            switch(userOperation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            Console.WriteLine("Result is " + result);
            Console.ReadKey();
        }
    }
}
