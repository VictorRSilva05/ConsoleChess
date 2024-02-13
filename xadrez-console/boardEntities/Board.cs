using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.boardEntities
{
    internal class Board
    {
        public int Line { get; set; }
        public int Column { get; set; }
        private Piece[,] Pieces;

        public Board(int line, int column)
        {
            Line = line;
            Column = column;
            Pieces = new Piece[line, column];
        }

        public Piece Piece(int line, int column)
        {
            return Pieces[line, column];
        }

        public Piece Piece(Position position)
        {
            return Pieces[position.Line, position.Column];
        }

        public bool PieceExists(Position position)
        {
            ValidatePosition(position);
            return Piece(position) != null;
        }

        public void PlacePiece(Piece piece, Position position)
        {
            if (PieceExists(position))
            {
                throw new BoardException("There's already a piece in this position");
            }
            Pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }

        public Piece RemovePiece(Position position)
        {
            if (Piece(position) == null)
            {
                return null;
            }
            else
            {
                Piece aux = Piece(position);
                aux.Position = null;
                Pieces[position.Line, position.Column] = null;
                return aux;
            }
        }


        public bool ValidPosition(Position position)
        {
            if (position.Line < 0 || position.Line >= Line || position.Column < 0 || position.Column >= Column)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position position)
        {
            if (!ValidPosition(position))
            {
                throw new BoardException("Invalid position");
            }
        }
    }
}
