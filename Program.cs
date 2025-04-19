using System;
using ShipGame.GridClass;
using ShipGame.ShipClass;
using ShipGame.PlayerClass;

namespace ShipGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.setShips();
            
            Console.WriteLine("Hello World!");
        }
    }
}