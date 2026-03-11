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
        private Map map;
        private Player player;
        

        public void Initialise()
        {
            map = new Map();
            player = new Player(new Vector2(5, 5), this);
            Draw();

        }
        /// <summary>
        /// The update for inputs and calculations for the game
        /// </summary>
        /// <returns> true if continuing to play, or false when we want to stop</returns>

        public bool Update()
        {
            // inputs
            ConsoleKey playerInput = Console.ReadKey().Key;

            if (playerInput == ConsoleKey.Escape)
                return false;

            // pass the input to the player
            player.Update(playerInput);

            return true;
        }

        public bool HasCollided(Vector2 position)
        {
            return map.HasCollided(position);
        }

        
        public void Draw()
        {
            // Outputs

            // Store Graphics to display
            // Console.Clear();
            string mapDisplay = "";
            // Loop through the Y axis
            for (int y = 0; y < map.MapSize.Y; y++)
            {
                // Loop through x array
                for (int x = 0; x < map.MapSize.X; x++)
                {
                    // Draw things to the world
                    if (x == player.Position.X && y == player.Position.Y)
                    {
                        // Draw Player
                        mapDisplay += " " + player.Draw();
                    }
                    else
                    {
                        mapDisplay += " " + map.Draw(new Vector2(x,y));
                    }

                }
                Console.SetCursorPosition(0, 0);
                mapDisplay += "\n"; // This is saying "Go to next line"
            }
            Console.WriteLine(mapDisplay);
        }
    }
}
