using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topdown_game
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Vector2 playerPos = new Vector2(4, 6);
            Console.WriteLine(playerPos.X + " " + playerPos.Y);

            playerPos = playerPos + new Vector2(1, 0);
            Console.WriteLine(playerPos.X + " " + playerPos.Y);

            Game game = new Game();

            game.Initialise();
            game.Draw();

            bool isPlaying = true;

            do
            {
                isPlaying = game.Update();
                game.Draw();


            } while (isPlaying == true);





        }
    }
}
