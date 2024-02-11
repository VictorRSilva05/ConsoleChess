using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.Board
{
    internal class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QtMovements { get; protected set; }
        public Board Board { get; protected set; }

        public Piece()
        {

        }

        public Piece(Position position, Color color, int qtMovements, Board board)
        {
            Position = position;
            Color = color;
            QtMovements = qtMovements;
            Board = board;
        }


    }
}
