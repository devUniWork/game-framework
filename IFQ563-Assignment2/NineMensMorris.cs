using System;
namespace IFQ563_Assignment2
{
    public class NineMensMorris 
    {
        public NineMensMorris()
        {
        }
        private char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public  void Introduction()
        {
            Console.WriteLine("Welcome to Nine Mens Morris.");
            Console.WriteLine("Apologies this game is still under construction");
            //DrawBoard(board)
        }
        public void DrawBoard(char[] board)
        {
            Console.Clear();
            Console.WriteLine("(00)-----------------------(01)------------------------(02)");
            Console.WriteLine("|                           |                             |");
            Console.WriteLine("|                           |                             |");
            Console.WriteLine("|                           |                             |");
            Console.WriteLine("|      (08)----------------(09)----------------(10)       |");
            Console.WriteLine("|       |                   |                    |        |");
            Console.WriteLine("|       |                   |                    |        |");
            Console.WriteLine("|       |                   |                    |        |");
            Console.WriteLine("|       |        (16)------(17)-------(18)       |        |");
            Console.WriteLine("|       |         |                   |          |        |");
            Console.WriteLine("|       |         |                   |          |        |");
            Console.WriteLine("|       |         |                   |          |        |");
            Console.WriteLine("(03)---(11)------(19)                 (20)------(12)---(04)");
            Console.WriteLine("|       |         |                   |          |        |");
            Console.WriteLine("|       |         |                   |          |        |");
            Console.WriteLine("|       |         |                   |          |        |");
            Console.WriteLine("|       |       (21)-------(22)-------(23)       |        |");
            Console.WriteLine("|       |                   |                    |        |");
            Console.WriteLine("|       |                   |                    |        |");
            Console.WriteLine("|       |                   |                    |        |");
            Console.WriteLine("|      (13)----------------(14)-----------------(15)      |");
            Console.WriteLine("|                           |                             |");
            Console.WriteLine("|                           |                             |");
            Console.WriteLine("|                           |                             |");
            Console.WriteLine("(05)----------------------(06)-------------------------(07)");
            Console.WriteLine("\n");
        }
    }
}
