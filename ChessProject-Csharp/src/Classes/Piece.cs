using System;

namespace SolarWinds.MSP.Chess
{
    public class Piece 
    {
        protected ChessBoard chessBoard;
        protected int xCoordinate;
        protected int yCoordinate;
        protected PieceColor pieceColor;
        protected PieceType pieceType;

        public Piece(PieceColor pieceColor)
        {
            PieceColor = pieceColor;
        }

        public Piece(PieceColor pieceColor, int xCoordinate, int yCoordinate)
        {
            PieceColor = pieceColor;
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        public ChessBoard ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        public int XCoordinate
        {
            get { return xCoordinate; }
            set { xCoordinate = value; }
        }
        
        public int YCoordinate
        {
            get { return yCoordinate; }
            set { yCoordinate = value; }
        }

        public PieceColor PieceColor
        {
            get { return pieceColor; }
            private set { pieceColor = value; }
        }

        public PieceType PieceType 
        {
            get {return pieceType;} 
            set {pieceType = value;}
        }
        
        public override string ToString()
        {
            return CurrentPositionAsString();
        }

        public string CurrentPositionAsString()
        {
            return string.Format("Current X: {1}{0}Current Y: {2}{0}Piece Color: {3}", Environment.NewLine, XCoordinate, YCoordinate, PieceColor);
        }
    }
}
