using System;
using ShipGame.GridClass;
using ShipGame.ShipClass;

namespace ShipGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ship player = new Ship();
            Grid grid = new Grid();
            grid.resetGrid();
            grid.controlGrid();
            
            Console.WriteLine("Hello World!");
        }
    }
}