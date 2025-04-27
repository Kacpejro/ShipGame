using ShipGame.ShipClass;
using ShipGame.GridClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace ShipGame.PlayerClass
{
    internal class Player
    {
        private int x;
        private int y;
        public void attack(Grid map)
        {
            bool endMove = false;

            x = 0;
            y = 0;

            do
            {
                Console.Clear();
                map.showGrid(x, y);
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow: case ConsoleKey.W: if (y > 0) y--; break;
                    case ConsoleKey.DownArrow: case ConsoleKey.S: if (y < 7) y++; break;
                    case ConsoleKey.RightArrow: case ConsoleKey.D: if (x < 7) x++; break;
                    case ConsoleKey.LeftArrow: case ConsoleKey.A: if (x > 0) x--; break;
                    case ConsoleKey.Enter:
                        endMove = map.attackCheck(y, x, endMove);
                        break;
                }
            } while (endMove == false);
        }
    }
}
