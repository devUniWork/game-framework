using System;
namespace IFQ563_Assignment2
{
    public class Documentation : IDocumentation
    {
        public Documentation() 
        {
        }
        public void About()
        {
            Console.Write("Hello and Welcome to Generic Game FrameWork\n");
            Console.Write("This Software was written by Devin Reeks\n");
            Console.Write("For the purpose of Assignment 2 IFQ563\n");
            Console.Write("Currently TicTacToe is the only functional game\n");
            Console.Write("Please feel free to load any saved game you wish.\n");
            Console.Write("Games are automatically saved\n");
            Console.Write("But most importantly of all, don't forget to have fun!\n");
            Console.Write("\n");
            Console.Write("Press Enter to Return to Root Menu\n");
            Console.ReadLine();
        }

        public void Rules(string gameRules)
        {
            Console.Write(gameRules);
            Console.Write("But most importantly of all, don't forget to have fun!\n");
            Console.Write("\n");
            Console.Write("Press Enter to Return to Game Menu\n");
            Console.ReadLine();

        }
    }
}
