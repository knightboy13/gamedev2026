using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartupDungeonCrawler
{
    internal class Program
    {
        static Player player;
        static Random random = new Random();
        static void Main(string[] args)
        {
            SetupGame();
            GameLoop();
        }
        static void SetupGame()
        {
            Console.Title = "Startup Dungeon Prototype";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=== WELCOME TO THE DUNGEON ===");
            Console.Write("Enter your hero's name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name)) name = "Unknown Hero";

            player = new Player(name, 100, 15);
            Console.Clear();
            Console.WriteLine($"Welcome, {player.Name}. Your descent begins now...\n");
        }

        static void GameLoop()
        {
            while (player.IsAlive)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"HP: {player.Health}/{player.MaxHealth} | Potions: {player.Potions}");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Move Forward into the next room");
                Console.WriteLine("2. Drink a Potion (+30 HP)");
                Console.WriteLine("3. Retire from the dungeon (Quit)");
                Console.Write("> ");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        EnterNextRoom();
                        break;
                    case "2":
                        player.Heal();
                        break;
                    case "3":
                        Console.WriteLine($"You retired safely. Final Score: {player.RoomsCleared} rooms cleared.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, soldier. Focus!");
                        break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=== GAME OVER ===");
            Console.WriteLine($"You perished in the dark. You cleared {player.RoomsCleared} rooms.");
        }

        static void EnterNextRoom()
        {
            player.RoomsCleared++;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"--- Room {player.RoomsCleared} ---");

            int eventRoll = random.Next(1, 101); // Roll 1-100

            if (eventRoll <= 20)
            {
                // 20% chance of finding a potion
                player.Potions++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The room is empty, but you found a Health Potion shimmering on an altar!");
            }
            else if (eventRoll <= 50)
            {
                // 30% chance of a quiet room
                Console.WriteLine("This room is eerily quiet. You take a moment to steel your nerves.");
            }
            else
            {
                // 50% chance of a monster encounter
                BattleEncounter();
            }
        }

        static void BattleEncounter()
        {
            string[] enemyNames = { "Goblin", "Skeleton", "Feral Wolf", "Shadow Orc" };
            string enemyName = enemyNames[random.Next(enemyNames.Length)];
            Enemy enemy = new Enemy(enemyName, random.Next(30, 60), random.Next(8, 15));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"A wild {enemy.Name} springs from the shadows!");

            while (enemy.IsAlive && player.IsAlive)
            {
                Console.WriteLine($"\n{enemy.Name} HP: {enemy.Health}");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Flee back to previous room");
                Console.Write("> ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Player attacks enemy
                    int damageToEnemy = random.Next(player.AttackPower - 5, player.AttackPower + 5);
                    enemy.TakeDamage(damageToEnemy);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You slash the {enemy.Name} for {damageToEnemy} damage!");

                    if (enemy.IsAlive)
                    {
                        // Enemy attacks player
                        int damageToPlayer = random.Next(enemy.AttackPower - 3, enemy.AttackPower + 3);
                        player.TakeDamage(damageToPlayer);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"The {enemy.Name} strikes back for {damageToPlayer} damage!");
                    }
                }
                else if (choice == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You turn tail and run! You lose some ground but escape with your life.");
                    player.RoomsCleared--; // Penalty for fleeing
                    return;
                }
                else
                {
                    Console.WriteLine("Indecision costs you! The enemy seizes the opening.");
                    int damageToPlayer = enemy.AttackPower;
                    player.TakeDamage(damageToPlayer);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The {enemy.Name} hits you for {damageToPlayer} damage while you hesitate!");
                }
            }

            if (player.IsAlive)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nYou defeated the {enemy.Name}!");
            }
        }
    }

    class Player
    {
        public string Name { get; }
        public int MaxHealth { get; }
        public int Health { get; private set; }
        public int AttackPower { get; }
        public int Potions { get; set; } = 1;
        public int RoomsCleared { get; set; } = 0;
        public bool IsAlive => Health > 0;

        public Player(string name, int maxHealth, int attackPower)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;
            AttackPower = attackPower;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }

        public void Heal()
        {
            if (Potions > 0)
            {
                Health += 30;
                if (Health > MaxHealth) Health = MaxHealth;
                Potions--;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"You chug a potion. Health restored to {Health}.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You reach into your bag, but it's empty! No potions left.");
            }
        }
    }

    class Enemy
    {
        public string Name { get; }
        public int Health { get; private set; }
        public int AttackPower { get; }
        public bool IsAlive => Health > 0;

        public Enemy(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }
    }
}

