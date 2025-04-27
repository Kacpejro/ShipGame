using ShipGame.PlayerClass;
using System;
using ShipGame.GridClass;

namespace ShipGame.ShipClass
{
    public class Ship
    {
        private string rotation = "vertically";
        private int shipSize;
        private int x = 0;
        private int y = 0;

        public Ship(int size = 1)
        {
            shipSize = size;
        }


        public void placeShip(Grid map)
        {
            bool endMove = false;
            do
            {
                Console.Clear();
                map.refreshGrid();
                map.showPlacingShipGrid(rotation, shipSize, x, y);

                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine();
                Console.WriteLine(rotation);
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow: case ConsoleKey.W: if (y > 0) y--; break;
                    case ConsoleKey.DownArrow: case ConsoleKey.S: if ((rotation == "horizontally" && y < 7) || (rotation == "vertically" && y + shipSize - 1 < 7)) y++; break;
                    case ConsoleKey.RightArrow: case ConsoleKey.D: if ((rotation == "vertically" && x < 7) || (rotation == "horizontally" && x + shipSize - 1 < 7)) x++; break;
                    case ConsoleKey.LeftArrow: case ConsoleKey.A: if (x > 0) x--; break;
                    case ConsoleKey.R:
                        if ((rotation == "horizontally" && y + shipSize - 1 < 8) || (rotation == "vertically" && x + shipSize - 1 < 8))
                        {
                            rotation = (rotation == "horizontally") ? "vertically" : "horizontally";
                        }
                        break;
                    case ConsoleKey.Enter:
                        endMove = map.checkFreeSpace(rotation, shipSize , x, y, endMove);
                        break;
                }
            } while (endMove == false);
        }
    }

}