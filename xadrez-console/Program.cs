using xadrez_console.boardEntities;
namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            Screen.PrintBoard(board);

            Console.ReadLine();
        }
    }
}
