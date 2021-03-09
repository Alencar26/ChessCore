using System;
using board;

namespace chess
{
    class ChessMatch
    {
        public Board Board { get; private set; }
        private int Shift;
        private Color CurrentPlayer;
        public bool GameOver { get; private set; }

        public ChessMatch()
        {
            Board = new Board(8,8);
            Shift = 1;
            CurrentPlayer = Color.White;
            GameOver = false;
            PutPiecesOnTheBoard();
        }

        public void PerformMovement(Position origin, Position destination)
        {
            Piece piece = Board.RemovePiece(origin);
            piece.IncreaseNumberOfMovies();
            Piece capturedPiece =  Board.RemovePiece(destination);
            Board.PutPiece(piece, destination);
        }

        private void PutPiecesOnTheBoard()
        {
            Board.PutPiece(new Rook(Board, Color.White), new PositionChess('c',1).ToPosition()) ;
            Board.PutPiece(new Rook(Board, Color.White), new PositionChess('e', 1).ToPosition());
            Board.PutPiece(new King(Board, Color.White), new PositionChess('d', 1).ToPosition());
            Board.PutPiece(new Rook(Board, Color.White), new PositionChess('c', 2).ToPosition());
            Board.PutPiece(new Rook(Board, Color.White), new PositionChess('d', 2).ToPosition());
            Board.PutPiece(new Rook(Board, Color.White), new PositionChess('e', 2).ToPosition());

            Board.PutPiece(new Rook(Board, Color.Black), new PositionChess('c', 8).ToPosition());
            Board.PutPiece(new Rook(Board, Color.Black), new PositionChess('e', 8).ToPosition());
            Board.PutPiece(new King(Board, Color.Black), new PositionChess('d', 8).ToPosition());
            Board.PutPiece(new Rook(Board, Color.Black), new PositionChess('c', 7).ToPosition());
            Board.PutPiece(new Rook(Board, Color.Black), new PositionChess('d', 7).ToPosition());
            Board.PutPiece(new Rook(Board, Color.Black), new PositionChess('e', 7).ToPosition());
        }
    }
}
