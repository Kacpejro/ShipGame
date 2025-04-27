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
            Grid playerAtackMap = new Grid();
            Grid playerShipMap = new Grid();
            Grid enemyShipMap = new Grid();
            Player player = new Player();
            setShip(playerShipMap, enemyShipMap);

            bool isWinner = false;

            do
            {
                player.attack(playerShipMap);
                isWinner = playerShipMap.checkWin("Player");
            } while (isWinner == false);
            
            Console.WriteLine("Hello World!");
        }


        static void setShip(Grid playerShipMap, Grid enemyShipMap)
        {
            {
                Ship playerShip1 = new Ship(3);
                playerShip1.placeShip(playerShipMap);

                Ship playerShip2 = new Ship(3);
                playerShip2.placeShip(playerShipMap);

                Ship playerShip3 = new Ship(2);
                playerShip3.placeShip(playerShipMap);

                Ship playerShip4 = new Ship(2);
                playerShip4.placeShip(playerShipMap);

                Ship playerShip5 = new Ship(1);
                playerShip5.placeShip(playerShipMap);

                Ship playerShip6 = new Ship(1);
                playerShip6.placeShip(playerShipMap);
            }
        }
    }
}