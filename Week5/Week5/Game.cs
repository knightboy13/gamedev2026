using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    internal class Game
    {
        int playerHealth = 100;
        int monsterDamage = 30;
        public void Start()
        {
            Console.WriteLine("My game has begun!");
            Console.ReadKey();
            MonsterEncounter();
            MonsterAttack(monsterDamage);
            MonsterAttack( monsterDamage * 2);
        }

        private void MonsterEncounter()
        {
            Console.WriteLine("A vicious monster appears!");
            Console.ReadKey();
        }

        private void MonsterAttack(int damage)
        {
            playerHealth -= damage;
            Console.WriteLine("The monster attacks you for " + damage + " Points of damage");
            Console.WriteLine("You have " + playerHealth + " health left");
            Console.ReadKey();
        }

        string FunctionWithReturnValue(int first, int second)
        {
            if(first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

    }
}
