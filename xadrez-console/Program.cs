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
                ChessMatch match = new ChessMatch();

                while (!match.Finished)
                {
                    Console.Clear();
                    Screen.PrintBoard(match.Board);

                    Console.Write("\n\nOrigin: ");
                    Position origin = Screen.ReadChessPosition().ToPosition();
                    Console.Write("Destiny: ");
                    Position destiny = Screen.ReadChessPosition().ToPosition(); 

                    match.Move(origin, destiny); 
                }
                
            }

            catch (BoardException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
