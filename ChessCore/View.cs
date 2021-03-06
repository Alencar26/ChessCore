﻿using System;
using board;
using chess;

namespace ChessCore
{
    class View
    {
        public static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.Lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Columns; j++)
                {
                    if (board.Piece(i, j) == null)
                    {
                        Console.Write("_ ");
                    }
                    else
                    {
                        PrintPiece(board.Piece(i, j));
                        Console.Write(" ");
                    }
                }
                Console.Write("\n"); 
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static PositionChess ReadPositionChess()
        {
            string input = Console.ReadLine();

            char column = input[0];
            int line = int.Parse(input[1].ToString());

            return new PositionChess(column, line);
        }

        public static void PrintPiece(Piece piece)
        {
            if (piece.Color == Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor whiteColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = whiteColor;
            }
        }
    }
}
