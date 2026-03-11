using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster monsterOne = new Monster();
            Monster monsterTwo = new Monster("Barry", 60, 5);

            monsterOne.Attack();
            monsterOne.TakeDamage(20);
            monsterTwo.Attack();

            Console.ReadKey();
        }
    }
}
