﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.boardEntities;
using xadrez_console.chess;

namespace xadrez_console
{
    internal class Screen
    {
        public static void PrintBoard(Board board)
        {

            for (int i = 0; i < board.Line; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Column; j++)
                {
                    if (board.Piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        PrintPiece(board.Piece(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("  a b c d e f g h");
        }

        public static void PrintPiece(Piece piece)
        {
            if(piece.Color == Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }
    }
}
