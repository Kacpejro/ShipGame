using System;

namespace ShipGame
{
    //public class Ship
    //{

    //}
    public class Grid
    {
        private string[,] grid = new string[10,10];
        public void resetGrid()
        {
            for (int i = 0; i < 10;  i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    grid[i, j] = " ";
                }
            }
        }
        public void showGrid()
        {
            for (int i = 0; i < 10 ; i++)
            {
                for (int j = 0; j < 10 ; j++)
                {
                    Console.Write(grid[i,j]);
                    if (j != 9)
                    {
                        Console.Write(" | ");
                    }
                }
                Console.WriteLine();

                if (i != 9)
                {
                    Console.WriteLine("--+---+---+---+---+---+---+---+---+--");
                }
            }
        }

        //public void interactiveGrid()
        //{
        //    bool endMove = false;
        //    do
        //    {
        //        Console.ReadKey();
        //    } while (endMove = false);
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid();
            grid.resetGrid();
            grid.showGrid();
            Console.WriteLine("Hello World!");
        }
    }
}