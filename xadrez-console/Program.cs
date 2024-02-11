using xadrez_console.boardEntities;
using xadrez_console.chess;
namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            board.PlacePiece(new Tower(board, Color.Black), new Position(0,0));

            Screen.PrintBoard(board);

            Console.ReadLine();
        }
    }
}
