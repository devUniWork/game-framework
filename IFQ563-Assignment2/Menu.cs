using System;
namespace IFQ563_Assignment2
{
    public class Menu
    {
        public RootMenuSelection RootMenu()
        {
            Console.Clear();
            Console.Write("Press 1 for TicTacToe\n");
            Console.Write("Press 2 for Reversi -- under-construction\n");
            Console.Write("Press 3 for Nine morris men -- under-construction\n");
            Console.Write("Press 4 to load game\n");
            Console.Write("Press 5 to view high scores\n");
            Console.Write("Press 6 to view About\n");
            Console.Write("Press 7 to quit\n");
            return (RootMenuSelection)Convert.ToInt32(Console.ReadLine());
        }
        public SubMenuGame GameMenu(String introduction)
        {
            Console.Clear();
            Console.Write(introduction);
            Console.Write("\n");
            Console.Write("Press 1 for Play Human Vs Human\n");
            Console.Write("Press 2 for Play Human Vs Computer\n");
            Console.Write("Press 3 to load game\n");
            Console.Write("Press 4 to view high scores\n");
            Console.Write("Press 5 to view Rules\n");
            Console.Write("Press 6 to quit\n");
            return (SubMenuGame)Convert.ToInt32(Console.ReadLine());
        }
        
    }
}
