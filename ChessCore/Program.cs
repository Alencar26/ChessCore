using ChessCore.Board;
using System;

namespace ChessCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // test class Position
            Position P = new Position(3, 4);

            Console.WriteLine($"Position: {P}");
        }
    }
}
