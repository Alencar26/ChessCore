using board;
using System;

namespace ChessCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8,8);
            View.PrintBoard(board);

            Console.WriteLine($"");
        }
    }
}
