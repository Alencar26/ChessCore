using board;

namespace chess
{
    class Rook : Piece
    {
        public Rook(Board board, Color color) : base(board, color) { }

        public override string ToString()
        {
            return "T";
        }

        private bool CanMove(Position position)
        {
            Piece piece = Board.Piece(position);
            return piece == null || piece.Color != Color;
        }

        public override bool[,] PossibleMovements()
        {
            bool[,] matrix = new bool[Board.Lines, Board.Columns];

            Position position = new Position(0, 0);

            //up
            position.SetValues(position.Line - 1, position.Column);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Line, position.Column] = true;
                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                    break;
                position.Line -= 1;
            }

            //right
            position.SetValues(position.Line, position.Column + 1);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Line, position.Column] = true;
                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                    break;
                position.Line += 1;
            }

            //down
            position.SetValues(position.Line + 1, position.Column);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Line, position.Column] = true;
                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                    break;
                position.Line += 1;
            }

            //left
            position.SetValues(position.Line, position.Column - 1);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Line, position.Column] = true;
                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                    break;
                position.Line -= 1;
            }

            return matrix;
        }
    }
}
