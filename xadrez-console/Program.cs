using xadrez_console.boardEntities;
using xadrez_console.chess;
namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);
                board.PlacePiece(new Tower(board, Color.Black), new Position(0, 0));
                board.PlacePiece(new Tower(board, Color.Black), new Position(1, 3));
                board.PlacePiece(new King(board, Color.Black), new Position(0, 2));

                board.PlacePiece(new Tower(board, Color.White), new Position(3, 5));
                

                Screen.PrintBoard(board);

            }

            catch (BoardException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
