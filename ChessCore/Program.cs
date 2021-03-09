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
                ChessMatch chessMatch = new ChessMatch();

                while (!chessMatch.GameOver)
                {


                    Console.Clear();
                    View.PrintBoard(chessMatch.Board);

                    Console.Write("Origem: ");
                    Position origin = View.ReadPositionChess().ToPosition();

                    Console.Write("Destino: ");
                    Position destination = View.ReadPositionChess().ToPosition();

                    chessMatch.PerformMovement(origin, destination);

                }

                
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            } 
        }
    }
}
