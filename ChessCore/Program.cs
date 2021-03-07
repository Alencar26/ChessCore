using board;
using chess;
using System;

namespace ChessCore
{
    class Program
    {
        static void Main(string[] args)
        {
            PositionChess position = new PositionChess('b',5);

            Console.WriteLine(position.ToPosition());

            
        }
    }
}
