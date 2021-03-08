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
                board.PutPiece(new Rook(board, Color.White), new Position(2, 3));
                board.PutPiece(new King(board, Color.Black), new Position(5, 1));
                board.PutPiece(new Rook(board, Color.White), new Position(4, 4));
                board.PutPiece(new King(board, Color.Black), new Position(4, 1));
                board.PutPiece(new Rook(board, Color.White), new Position(2, 1));
                board.PutPiece(new King(board, Color.Black), new Position(5, 0));

                View.PrintBoard(board);
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            } 
        }
    }
}
