using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topdown_game
{
    internal class Player
    {
        private Vector2 position = new Vector2();
        // Property
        public Vector2 Position { get { return position; } }
        private char icon = 'A';

        private Game game;

        public Player(Vector2 newPosition, Game game)
        {
            position = newPosition;
            this.game = game;
        }

        public void Update(ConsoleKey input)
        {
            Vector2 direction = new Vector2();

            switch(input)
            {
                case ConsoleKey.W:
                    direction = new Vector2(0, -1);
                    break;
                case ConsoleKey.S:
                    direction = new Vector2(0, 1);
                    break;
                case ConsoleKey.A:
                    direction = new Vector2(-1, 0);
                    break;
                case ConsoleKey.D:
                    direction = new Vector2(1, 0);
                    break;
            }
            // store player old position
            Vector2 previousPosition = position;
            // move player 
            position += direction;
            // check if player should be there
            if(game.HasCollided(position))
            {
                // change us back
                position = previousPosition;
            }
        }

        public char Draw()
        {
            return icon;
        }
    }
}
