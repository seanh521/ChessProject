using NUnit.Framework;

namespace SolarWinds.MSP.Chess
{
	[TestFixture]
	public class PawnTest
	{
		private ChessBoard chessBoard;
		private Pawn blackPawn;
		private Pawn whitePawn;

		[SetUp]
		public void SetUp()	
		{
			chessBoard = new ChessBoard();
			blackPawn = new Pawn(PieceColor.Black);
			whitePawn = new Pawn(PieceColor.White);
		}

		[Test]
		public void ChessBoard_Add_Sets_XCoordinate()
		{
			chessBoard.Add(blackPawn, 6, 3, PieceColor.Black, chessBoard);
			Assert.AreEqual(blackPawn.XCoordinate, 6);
		}

		[Test]
		public void ChessBoard_Add_Sets_YCoordinate()
		{
			chessBoard.Add(blackPawn, 6, 3, PieceColor.Black, chessBoard);
			Assert.AreEqual(blackPawn.YCoordinate, 3);
		}

		[Test]
		public void Pawn_Move_IllegalCoordinates_Right_DoesNotMove()
		{
			chessBoard.Add(blackPawn, 6, 3, PieceColor.Black, chessBoard);
			blackPawn.Move(7, 3);
            Assert.AreEqual(blackPawn.XCoordinate, 6);
            Assert.AreEqual(blackPawn.YCoordinate, 3);
		}

		[Test]
		public void Pawn_Move_IllegalCoordinates_Left_DoesNotMove()
		{
			chessBoard.Add(blackPawn, 6, 3, PieceColor.Black, chessBoard);
			blackPawn.Move(4, 3);
            Assert.AreEqual(blackPawn.XCoordinate, 6);
            Assert.AreEqual(blackPawn.YCoordinate, 3);
		}

		[Test]
		public void Black_Pawn_Move_LegalCoordinates_Forward_UpdatesCoordinates()
		{
			chessBoard.Add(blackPawn, 6, 3, PieceColor.Black, chessBoard);
			blackPawn.Move(6, 2);
			Assert.AreEqual(blackPawn.XCoordinate, 6);
            Assert.AreEqual(blackPawn.YCoordinate, 2);
		}

		[Test]
		public void White_Pawn_Move_LegalCoordinates_Forward_UpdatesCoordinates()
		{
			chessBoard.Add(whitePawn, 1, 3, PieceColor.Black, chessBoard);
			whitePawn.Move(1, 4);
			Assert.AreEqual(whitePawn.XCoordinate, 1);
            Assert.AreEqual(whitePawn.YCoordinate, 4);
		}
	}
}
