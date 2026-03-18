using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Monster monsterOne = new Monster();
            //Monster monsterTwo = new Monster("Barry", 60, 5);

            Monster[] monsters = new Monster[2];



            string configFile = "monster_stats.txt";

            if (File.Exists(configFile))
            {
                LoadMonsterStats(monsters, configFile);
                Console.WriteLine("Loaded your custom monsters!");
            }
            else
            {
                monsters[0] = new Monster();
                monsters[1] = new Monster("Barry", 60, 5);

                SaveMonsterStats(monsters, configFile);
                Console.WriteLine("Created monster_stats.txt");
            }



            bool isFighting = true;

            int currentMonsterIndex = 0;
            int otherMonsterIndex = 1;
            while (isFighting == true)
            {
                string input = Console.ReadLine();
                

                if (input == "attack")
                {
                    Console.WriteLine("Player chose attack for Monster!");
                }
                int attackDamage = monsters[currentMonsterIndex].Attack();

                if (monsters[otherMonsterIndex].TakeDamage(attackDamage) == true)
                {
                    isFighting = false;
                }

                currentMonsterIndex++;

                if (currentMonsterIndex >= monsters.Length)
                {
                    currentMonsterIndex = 0;
                }

                otherMonsterIndex++;
                if (otherMonsterIndex >= monsters.Length)
                {
                    otherMonsterIndex = 1;
                }
            }
            Console.ReadKey();


        }

        static void SaveMonsterStats(Monster[] monsters, string fileName)
        {
            StreamWriter file = new StreamWriter(fileName);

            // save first monster
            file.WriteLine(monsters[0].name);
            file.WriteLine(monsters[0].health);
            file.WriteLine(monsters[0].attackDamage);

            // save Barry
            file.WriteLine(monsters[1].name);
            file.WriteLine(monsters[1].health);
            file.WriteLine(monsters[1].attackDamage);

            file.Close();
        }

        static void LoadMonsterStats(Monster[] monsters, string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            //load first monster (lines 0, 1, 2)
            monsters[0] = new Monster(lines[0], int.Parse(lines[1]), int.Parse(lines[2]));

            // load Barry (lines 0, 1, 2)
            monsters[1] = new Monster(lines[3], int.Parse(lines[4]), int.Parse(lines[5]));

        }
    }
}
