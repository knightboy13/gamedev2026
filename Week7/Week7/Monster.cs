using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week7
{
    class Monster
    {
        public string name = "Monster";
        public int health;
        public int attackDamage;

        public Monster()
        {
            health = 50;
            attackDamage = 2;
        }

        public Monster(string name, int health, int attackDamage)
        {
            this.name = name;
            this.health = health;
            this.attackDamage = attackDamage;
        }

        public int Attack()
        {

            int damage = attackDamage;

            Random randomNum = new Random();

            damage -= randomNum.Next(0, 3);
            Console.WriteLine(name + " winds up for an attack ");
            return damage;
        }

        public bool TakeDamage(int damage)
        {

            health -= damage;
            Console.WriteLine(name + " took " + damage + " damage. " + health + " health remaining");

            if(health <= 0)
            {
                Console.WriteLine(name + " has kicked the bucket");
                return true;
            }
            return false;

        }
    }
}
