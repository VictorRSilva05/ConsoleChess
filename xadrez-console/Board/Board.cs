using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.Board
{
    internal class Board
    {
        public int Lines {  get; set; }
        public int Columns { get; set; }
        public Piece[,] Pieces;
    }
}
