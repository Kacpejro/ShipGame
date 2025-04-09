using System;
using ShipGame.GridClass;

namespace ShipGame.ShipClass
{
    public class Ship : Grid
    {
        private string rotation = "vertically";
        private int shipSize = 3;
        private bool goodMove = false;

        public void showShipGrid()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == y && j == x)
                    {
                        grid[i, j] = "O";
                        if (rotation == "horizontally")
                        {
                            for (int k = shipSize; k > 0; k--)
                            {
                                grid[i, j + k - 1] = "O";
                            }
                        }
                        else
                        {
                            for (int k = shipSize; k > 0; k--)
                            {
                                grid[i + k - 1, j] = "O";
                            }
                        }
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(grid[i, j]);
                        if (j != 7)
                        {
                            Console.Write(" ");
                            Console.ResetColor();
                            Console.Write("| ");
                        }
                        else
                        {
                            Console.ResetColor();
                        }
                        goodMove = true;
                    }
                    else if (j == x - 1 && i == y)
                    {
                        Console.Write(grid[i, j]);
                        if (j != 7)
                        {
                            Console.Write(" |");
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.Write(" ");
                            Console.ResetColor();
                        }
                        goodMove = true;
                    }
                    else
                    {
                        Console.Write(grid[i, j]);
                        if (j != 7)
                        {
                            Console.Write(" | ");
                        }
                        goodMove = true;
                    }
                }

                Console.WriteLine();

                if (i != 7)
                {
                    Console.WriteLine("--+---+---+---+---+---+---+--");
                }
            }
        }

        public void controlShip()
        {
            bool endMove = false;
            do
            {
                Console.Clear();
                resetGrid();
                showShipGrid();

                Console.WriteLine(x);
                Console.WriteLine(y);
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow: case ConsoleKey.W: if (y > 0) y--; break;
                    case ConsoleKey.DownArrow: case ConsoleKey.S: if ((rotation == "horizontally" && y < 7) || (rotation == "vertically" && y + shipSize - 1 < 7)) y++; break;
                    case ConsoleKey.RightArrow: case ConsoleKey.D: if ((rotation == "vertically" && x < 7) || (rotation == "horizontally" && x + shipSize - 1 < 7)) x++; break;
                    case ConsoleKey.LeftArrow: case ConsoleKey.A: if (x > 0) x--; break;
                    case ConsoleKey.R: rotation = (rotation == "horizontally") ? "vertically" : "horizontally"; break;
                    case ConsoleKey.Enter:
                        endMove = true;
                        break; // <------ Add method for placing ships
                }
            } while (endMove == false);
        }
    }

}