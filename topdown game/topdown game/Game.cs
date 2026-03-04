using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace topdown_game
{
    internal class Game
    {
        int playerX = 5;
        int playerY = 5;
        char playerIcon = 'A';
        // Y - First array
        // X - internal array of Ys
        char[,] map =
        {
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '0', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '0', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '0', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.'},
            };

        public void Initialise()
        {
            

        }
        /// <summary>
        /// The update for inputs and calculations for the game
        /// </summary>
        /// <returns> true if continuing to play, or false when we want to stop</returns>

        public bool Update()
        {
            // inputs
            ConsoleKey playerInput = Console.ReadKey().Key;
            int previousX = playerX;
            int previousY = playerY;
            // Calculations
            switch (playerInput)
            {
                case ConsoleKey.Escape:
                    return false;
                case ConsoleKey.W:
                    playerY -= 1;
                    break;
                case ConsoleKey.S:
                    playerY += 1;
                    break;
                case ConsoleKey.A:
                    playerX -= 1;
                    break;
                case ConsoleKey.D:
                    playerX += 1;
                    break;
            }

            if (HasCollided(playerX, playerY) == true)
            {
                playerX = previousX;
                playerY = previousY;
            }

            return true;
        }

        /// <summary>
        /// Collison check with map
        /// </summary>
        /// <param name="x">Coordinate</param>
        /// <param name="y">Coordinate</param>
        /// <returns>true if hit something it can't move to. False if it can</returns>
        private bool HasCollided(int x, int y)
        {
            // map bounds check
            if (y < 0 || x < 0 // has passed the top or left of the map
                || y >= map.GetLength(0) || x >= map.GetLength(1)) // has passed the bottle
                return true;

            // tile collision check
            if (map[y, x] == '0')
                return true;

            return false;
        }

        public void Draw()
        {
            // Outputs

            // Store Graphics to display
            // Console.Clear();
            string mapDisplay = "";
            // Loop through the Y axis
            for (int y = 0; y < map.GetLength(0); y++)
            {
                // Loop through x array
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    // Draw things to the world
                    if (x == playerX && y == playerY)
                    {
                        // Draw Player
                        mapDisplay += " " + playerIcon;
                    }
                    else
                    {
                        mapDisplay += " " + map[y, x];
                    }

                }
                Console.SetCursorPosition(0, 0);
                mapDisplay += "\n"; // This is saying "Go to next line"
            }
            Console.WriteLine(mapDisplay);
        }
    }
}
