using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.Board
{
    internal class Position
    {
        public int Lines {  get; set; }
        public int  Columns { get; set; }

        public Position() { }

        public Position(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
        }

        public override string ToString()
        {
            return Lines + ", " + Columns;
        }
    }
}
