using System;
namespace IFQ563_Assignment2
{
    public class Reversi
    {
        private char[] board = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p' };

        public  void Introduction()
        {
            Console.WriteLine("Welcome to Reversi.");
            Console.WriteLine("Apologies this is still under construction");
        }
        public void DrawBoard(char[] board)
        {
            //base.DrawBoard(board);
            Console.WriteLine("     |     |     |      ");
            Console.WriteLine($"  {board[0]}  |  {board[1]}  |  {board[2]}  |  {board[3]}  ", board[0], board[1], board[2], board[3]);
            Console.WriteLine("_____|_____|_____|_____");
            Console.WriteLine("     |     |     |     ");
            Console.WriteLine($"  {board[4]}  |  {board[5]}  |  {board[6]}  |  {board[7]}  ", board[4], board[5], board[6], board[7]);
            Console.WriteLine("_____|_____|_____|_____");
            Console.WriteLine("     |     |     |     ");
            Console.WriteLine($"  {board[8]}  |  {board[9]}  |  {board[10]}  |  {board[11]}  ", board[8], board[9], board[10], board[11]);
            Console.WriteLine("_____|_____|_____|_____");
            Console.WriteLine("     |     |     |     ");
            Console.WriteLine($"  {board[12]}  |  {board[13]}  |  {board[14]}  |  {board[15]}  ", board[12], board[13], board[14], board[15]);
            Console.WriteLine("     |     |     |     ");
        }
    }
}
