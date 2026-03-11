using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topdown_game
{
    internal class Vector2
    {
        private int x, y;
        // int x
        //int y

        //Property
        public int X { 
            get{ return x; } 
        }

        public int Y { 
            get { return y; }
        }
        public Vector2()
        {
            x = 0;
            y = 0;
        }

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x + v2.x, v1.y + v2.y);
        }

        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x - v2.x, v1.y + v2.y);
        }
    }
}
