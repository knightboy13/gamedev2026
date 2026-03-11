using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_tutorial
{
    internal class Monster
    {
        string name = "Monster";
        int health;
        int attackDamage;

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

        public void Attack()
        {
            Console.WriteLine(name + " attacked for " + attackDamage);
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
            Console.WriteLine(name + " was hit for " + damage);
            Console.WriteLine(name + " has " + health + " Health left.");
        }
    }
}
