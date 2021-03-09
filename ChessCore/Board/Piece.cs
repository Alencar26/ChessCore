namespace board
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int NumberOfMovies { get; set; }
        public Board Board { get; protected set; }

        public Piece(Board board, Color color)
        {
            Position = null;
            Board = board;
            Color = color;
            NumberOfMovies = 0;
        }

        public void IncreaseNumberOfMovies()
        {
            NumberOfMovies++;
        }
    }
}
