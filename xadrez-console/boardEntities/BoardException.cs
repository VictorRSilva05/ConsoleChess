using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.boardEntities
{
    internal class BoardException : Exception
    {
        public BoardException(string msg) : base(msg) { }
    }
}
