using xadrez_console.boardEntities;
using xadrez_console.chess;
namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChessPosition chessPosition = new ChessPosition('c', 7);

            Console.WriteLine(chessPosition);

            Console.WriteLine(chessPosition.ToPosition());
        }
    }
}
