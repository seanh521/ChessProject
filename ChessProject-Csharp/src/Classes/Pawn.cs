using System;

namespace SolarWinds.MSP.Chess
{
    public class Pawn : Piece, IMovement
    {

        public Pawn(PieceColor pieceColor) : base(pieceColor) {}

        public void Move(int newX, int newY)
        {
            //If piece colour is black
            if((int)PieceColor == 0)
            {
                if(newX != XCoordinate && newY > (YCoordinate - 1) && newY < 0)
                {
                    Console.WriteLine("Illegal Move");
                }
                else
                {
                    yCoordinate = newY;
                }
            }

            //If piece colour is white
            if((int)PieceColor == 1)
            {
                if(newX != xCoordinate && newY < (yCoordinate + 1) && newY < 0)
                {
                    Console.WriteLine("Illegal Move");
                }
                else
                {
                    yCoordinate = newY;
                }
            }
            
        }

        public void Capture(int newX, int newY, bool isOccupied)
        {
            throw new NotImplementedException("Capture Method needs to be implemented");
        }

    }
}
