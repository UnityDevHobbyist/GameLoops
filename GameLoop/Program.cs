using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoop
{
    internal class Program
    {
        static bool gameOver; // true or false
        static int x;
        static int y;

        static void Main(string[] args)
        {
            gameOver = false;

            x = 0;
            y = 0;

            // game loop
            while(!gameOver)
            {
                PlayerUpdate();
                PlayerDraw();
            }

            Console.WriteLine("GAME OVER!");
        }

        static void PlayerUpdate()
        {
            // read user input
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);

            // update player position
            if (input.Key == ConsoleKey.W)
                x -= 1;
            else if (input.Key == ConsoleKey.S)
                x += 1;
            else if (input.Key == ConsoleKey.A)
                y -= 1;
            else if (input.Key == ConsoleKey.D)
                y += 1;
            else if (input.Key == ConsoleKey.Escape)
                gameOver = true;

            // DEBUG
            //Console.WriteLine("(" + x + "," + y + ")");
        }

        static void PlayerDraw()
        {
            Console.SetCursorPosition(y, x);
            Console.Write(".");
        }
    }
}
