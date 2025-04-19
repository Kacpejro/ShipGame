using ShipGame.ShipClass;
using ShipGame.GridClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShipGame.PlayerClass
{
    internal class Player
    {
        public void setShips()
        {
            Grid atackMap = new Grid();
            Grid shipMap = new Grid();

            Ship ship1 = new Ship(3);
            ship1.placeShip(shipMap);

            Ship ship2 = new Ship(3);
            ship2.placeShip(shipMap);

            Ship ship3 = new Ship(2);
            ship3.placeShip(shipMap);

            Ship ship4 = new Ship(2);
            ship4.placeShip(shipMap);

            Ship ship5 = new Ship(1);
            ship5.placeShip(shipMap);

            Ship ship6 = new Ship(1);
            ship6.placeShip(shipMap);
        }
    }
}
