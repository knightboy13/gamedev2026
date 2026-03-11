using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topdown_game
{
    internal class Map
    {
        // Y - First array
        // X - internal array of Ys
        private char[,] map =
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

        private Vector2 mapSize = new Vector2();

        public Vector2 MapSize { get { return mapSize; } }

        public Map()
        {
            mapSize = new Vector2(map.GetLength(1), map.GetLength(0));

        }

        public char Draw(Vector2 position)
        {
            return map[position.Y, position.X];
        }

        /// <summary>
        /// Collison check with map
        /// </summary>
        /// <param name="x">Coordinate</param>
        /// <param name="y">Coordinate</param>
        /// <returns>true if hit something it can't move to. False if it can</returns>
        public bool HasCollided(Vector2 position)
        {
            // map bounds check
            if (position.Y < 0 || position.X < 0 // has passed the top or left of the map
                || position.Y >= mapSize.Y || position.X >= mapSize.X) // has passed the bottle
                return true;

            // tile collision check
            if (map[position.Y, position.X] == '0')
                return true;

            return false;
        }

    }
}
