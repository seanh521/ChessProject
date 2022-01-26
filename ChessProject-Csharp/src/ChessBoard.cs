using System;

namespace SolarWinds.MSP.Chess
{
    public class ChessBoard
    {
        public static readonly int MaxBoardWidth = 7;
        public static readonly int MaxBoardHeight = 7;
        private Cell[,] boardCells;

        public ChessBoard ()
        {
            //Creating 2D array with type Cell
            boardCells = new Cell[MaxBoardWidth, MaxBoardHeight];

            //Populating the board with new board cells
            for(int row = 0; row < MaxBoardWidth; row++)
            {
                for(int column = 0; column < MaxBoardHeight; column++)
                {
                    boardCells[row,column] = new Cell(row,column);
                }
            }

        }

        public void Add(Pawn pawn, int xCoordinate, int yCoordinate, PieceColor pieceColor)
        {
            throw new NotImplementedException("Need to implement ChessBoard.Add()");
        }

        public bool IsLegalBoardPosition(int xCoordinate, int yCoordinate)
        {
            throw new NotImplementedException("Need to implement ChessBoard.IsLegalBoardPosition()");
        }
    }
}
