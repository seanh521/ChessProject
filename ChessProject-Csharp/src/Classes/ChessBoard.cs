using System;

namespace SolarWinds.MSP.Chess
{
    public class ChessBoard
    {
        public static readonly int MaxBoardWidth = 7;
        public static readonly int MaxBoardHeight = 7;
        public static readonly int MaxNoPawns = 7;
        public int amountOfPawns {get; set;}

        private Cell[,] boardCells;

        public ChessBoard ()
        {
            //Creating 2D array with type Cell
            boardCells = new Cell[MaxBoardWidth, MaxBoardHeight];

            //Populating the board with new board cells
            for(int x = 0; x < MaxBoardWidth; x++)
            {
                for(int y = 0; y < MaxBoardHeight; y++)
                {
                    boardCells[x,y] = new Cell(x,y);
                }
            }

        }

        public void Add(Pawn pawn, int xCoordinate, int yCoordinate, PieceColor pieceColor, ChessBoard chessBoard)
        {
            //Checking if the number of pawns on the board are below the Max number of Pawns
            if(chessBoard.amountOfPawns >= MaxNoPawns)
            {
                pawn.XCoordinate = -1;
                pawn.YCoordinate = -1;
                Console.WriteLine("The limit of pawns have been reached");
            }
            else
            {
                //Checking if the board cells are occupied
                if(chessBoard.boardCells[xCoordinate, yCoordinate].IsOccupied)
                {
                    pawn.XCoordinate = -1;
                    pawn.YCoordinate = -1;
                    Console.WriteLine("Space is occupied");
                }
                else
                {
                    //Making sure the piece stays within the boards bounds
                    if(xCoordinate > MaxBoardWidth || xCoordinate < 0)
                    {
                        Console.WriteLine("Piece out of bounds");
                    } 
                    else
                    {
                        //Setting the X Coordinate
                        pawn.XCoordinate = xCoordinate;
                    }
                    
                    //Making sure the piece stays within the boards bounds
                    if(yCoordinate > MaxBoardHeight || yCoordinate < 0)
                    {
                        Console.WriteLine("Piece out of bounds");
                    }
                    else
                    {
                        //Setting the Y Coordinates
                        pawn.YCoordinate = yCoordinate;
                    }
                    PopulateCellAttributes(pawn, xCoordinate, yCoordinate, chessBoard);
                    chessBoard.amountOfPawns++;
                }
            }

        }

        public bool IsLegalBoardPosition(int xCoordinate, int yCoordinate)
        {
            //Checking the x and y coordinate does not exceed the Max Coordinates
            if(xCoordinate > MaxBoardWidth || yCoordinate > MaxBoardHeight)
            {
                return false;
            }
            //Checking the x and y coordinate does not go below 0
            else if(xCoordinate < 0 || yCoordinate < 0)
            {
                return false;
            }
            else 
            {
                return true;
            } 
        }

        private void PopulateCellAttributes(Pawn pawn, int xCoordinate, int yCoordinate, ChessBoard chessBoard)
        {
            //Setting the pieces cell coordinates to the new coordinates 
            chessBoard.boardCells[pawn.XCoordinate, pawn.YCoordinate] = chessBoard.boardCells[xCoordinate, yCoordinate];
            //Setting occupied to true
            chessBoard.boardCells[pawn.XCoordinate, pawn.YCoordinate].IsOccupied = true;
        }
    }
}
