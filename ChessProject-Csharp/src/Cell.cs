using System;

namespace SolarWinds.MSP.Chess 
{

    public class Cell 
    {

        public int Row {get; set;}
        public int Column {get; set;}
        public bool IsOccupied {get; set;}
        public bool IsLegalMove {get; set;}

        public Cell(int row, int column)
        {
           Row = row;
           Column = column; 
        }
    }

}