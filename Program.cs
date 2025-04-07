using System;

namespace ShipGame
{
    //public class Ship
    //{

    //}
    public class Grid
    {
        private string[,] grid = new string[8,8];
        private int x = 0;
        private int y = 0;
        private string rotation;
        public void resetGrid()
        {
            for (int i = 0; i < 8;  i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    grid[i, j] = " ";
                }
            }
        }
        public void showGrid()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == y && j == x)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(grid[i, j]);
                        if (j != 7)
                        {
                            Console.Write(" ");
                            Console.ResetColor();
                            Console.Write("| ");
                        } else
                        {
                            Console.ResetColor();
                        }
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
                    }
                    else
                    {
                        Console.Write(grid[i, j]);
                        if (j != 7)
                        {
                            Console.Write(" | ");
                        }
                    }

                    
                }
                Console.WriteLine();

                if (i != 7)
                {
                    Console.WriteLine("--+---+---+---+---+---+---+--");
                }
            }
        }

        public void controlGrid()
        {
            bool endMove = false;
            do
            {
                Console.Clear();
                showGrid();

                Console.WriteLine(x);
                Console.WriteLine(y);
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow: case ConsoleKey.W: if (y > 0) y--; break;
                    case ConsoleKey.DownArrow: case ConsoleKey.S: if (y < 7) y++; break;
                    case ConsoleKey.RightArrow: case ConsoleKey.D: if (x < 7) x++; break;
                    case ConsoleKey.LeftArrow: case ConsoleKey.A: if (x > 0) x--; break;
                    case ConsoleKey.R: rotation = (rotation == "horizontally") ? "vertically" : "horizontally"; break;
                    case ConsoleKey.Enter:
                        endMove = true;
                        break; // <------ Add method for placing ships
                }
            } while (endMove == false);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid();
            grid.resetGrid();
            grid.controlGrid();
            Console.WriteLine("Hello World!");
        }
    }
}