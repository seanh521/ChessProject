using System;

namespace SolarWinds.MSP.Chess 
{

    public class Cell 
    {

        public int xCoordinate;
        public int yCoordinate;
        public bool isOccupied;

        public Cell(int x, int y)
        {
           xCoordinate = x;
           yCoordinate = y; 
        }

        public int XCoordinate
        {
            get {return xCoordinate;}
            set {xCoordinate = value;}
        }

        public int YCoordinate
        {
            get {return yCoordinate;}
            set {yCoordinate = value;}
        }

        public bool IsOccupied
        {
            get {return isOccupied;}
            set {isOccupied = value;}
        }
    }

}