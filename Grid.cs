using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipGame.GridClass
{
public class Grid
    {
        private string[,] grid = new string[8, 8];
        private bool goodMove = false;
        public void resetGrid()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    grid[i, j] = " ";
                }
            }
        }
        public void refreshGrid()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (grid[i, j] != "O")
                    {
                        grid[i, j] = " ";
                    }
                }
            }
        }

        private void saveShipPosition(string rotation, int shipSize, int x, int y)
        {
            if (rotation == "vertically")
            {
                for (int i = shipSize; i > 0; i--)
                {
                    grid[y + i - 1, x] = "O";
                } 
            } else if (rotation == "horizontally")
            {
                for (int i = shipSize; i > 0; i--)
                {
                    grid[y, x + i - 1] = "O";
                }
            }
            
        }

        public bool checkFreeSpace(string rotation, int shipSize, int x, int y, bool endMove = false)//Tutaj coś nie gra. Chuj wi co
        {
            bool isGoodPosision = true;
            if (rotation == "vertically")
            {
                for (int i = shipSize; i > 0; i--)
                {
                    if (grid[y + i - 1, x] == "O")
                    {
                        isGoodPosision = false;
                        break;
                    }
                }
            } else if (rotation == "horizontally")
            {
                for (int i = shipSize; i > 0; i--)
                {
                    if (grid[y, x + i - 1] == "O")
                    {
                        isGoodPosision = false;
                        break;
                    }
                }
            }
            if(isGoodPosision == true)
            {
                saveShipPosition(rotation, shipSize, x, y);
                endMove = true;
            }
            return endMove;
        }


        public void showShipGrid(string rotation, int shipSize, int x, int y)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == y && j == x)
                    {
                        if (rotation == "horizontally")
                        {
                            for (int k = shipSize; k > 0; k--)
                            {
                                if (grid[i, j + k - 1] != "O")
                                {
                                    grid[i, j + k - 1] = "0";
                                }
                            }
                        }
                        else
                        {
                            for (int k = shipSize; k > 0; k--)
                            {
                                if (grid[i + k - 1, j] != "O")
                                {
                                    grid[i + k - 1, j] = "0";
                                }
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
    }
}
