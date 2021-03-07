using board;
using chess;
using System;

namespace ChessCore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);

                board.PutPiece(new Rook(board, Color.Black), new Position(0, 0));
                board.PutPiece(new Rook(board, Color.Black), new Position(1, 3));
                board.PutPiece(new King(board, Color.Black), new Position(2, 4));

                View.PrintBoard(board);

                Console.WriteLine($"");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
