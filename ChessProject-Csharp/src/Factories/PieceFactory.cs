using System;

namespace SolarWinds.MSP.Chess
{
    public class PieceFactory
    {
        public Piece CreatePiece(PieceType pieceType, PieceColor pieceColor)
        {
            switch((int)pieceType)
            {
                case 0:
                    return new Pawn(pieceColor);
                case 1:
                    return new Piece(pieceColor); //Will be changed to Bishop when implemented
                case 2:
                    return new Piece(pieceColor); //Will be changed to Knight when implemented
                case 3:
                    return new Piece(pieceColor); //Will be changed to Rook when implemented
                case 4:
                    return new Piece(pieceColor); //Will be changed to Queen when implemented
                case 5:
                    return new Piece(pieceColor); //Will be changed to King when implemented
                default:
                    return new Piece(pieceColor);
            }
        }
    }
}