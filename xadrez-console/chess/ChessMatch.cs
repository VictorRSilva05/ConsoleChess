using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.boardEntities;
using xadrez_console.chess;

namespace xadrez_console.chess
{
    internal class ChessMatch
    {
        public Board Board { get; private set; }
        private int Turno;
        private Color CurrentPlayer;
        public bool Finished { get; private set; }
        public ChessMatch()
        {
            Board = new Board(8, 8);
            Turno = 1;
            CurrentPlayer = Color.White;
            Finished = false;
            PlacePieces();
        }

        public void Move(Position origin, Position destination)
        {
            Piece piece = Board.RemovePiece(origin);
            piece.IncrementQtMovements();
            Piece CapturePiece = Board.RemovePiece(destination);
            Board.PlacePiece(piece, destination);
        }

        private void PlacePieces()
        {
            Board.PlacePiece(new Tower(Board, Color.White), new ChessPosition('c', 1).ToPosition());
        }
    }
}
