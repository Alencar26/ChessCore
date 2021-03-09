using board;

namespace chess
{
    class King : Piece
    {
        public King(Board board, Color color) : base(board, color) {  }

        public override string ToString()
        {
            return "R";
        }

        private bool CanMove(Position position)
        {
            Piece piece = Board.Piece(position);
            return piece == null || piece.Color != Color;
        }

        public override bool[,] PossibleMovements()
        {
            bool[,] matrix = new bool[Board.Lines, Board.Columns];

            // testando
            Position position = new Position(0, 0);

            //up
            position.SetValues(position.Line - 1, position.Column);
            if (Board.ValidPosition(position) && CanMove(position))
                matrix[position.Line, position.Column] = true;

            //top right diagonal
            position.SetValues(position.Line - 1, position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
                matrix[position.Line, position.Column] = true;

            //right
            position.SetValues(position.Line, position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
                matrix[position.Line, position.Column] = true;

            //bottom right diagonal
            position.SetValues(position.Line + 1, position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
                matrix[position.Line, position.Column] = true;

            //dwon
            position.SetValues(position.Line + 1, position.Column);
            if (Board.ValidPosition(position) && CanMove(position))
                matrix[position.Line, position.Column] = true;

            //bottom left diagonal
            position.SetValues(position.Line + 1, position.Column - 1);
            if (Board.ValidPosition(position) && CanMove(position))
                matrix[position.Line, position.Column] = true;

            //left
            position.SetValues(position.Line, position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
                matrix[position.Line, position.Column] = true;

            //top left diagonal
            position.SetValues(position.Line - 1, position.Column - 1);
            if (Board.ValidPosition(position) && CanMove(position))
                matrix[position.Line, position.Column] = true;

            return matrix;
        }
    }
}
