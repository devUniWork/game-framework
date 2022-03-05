using System;
namespace IFQ563_Assignment2
{
    public class GameFactory
    {
        public void CreateGame(RootMenuSelection gameChoice)
        {
            if(gameChoice == RootMenuSelection.TicTacToe)
            {
                Menu menu = new Menu();
                var menuSelection = menu.GameMenu("Welcome to TicTacToe.\n");
                TicTacToe ticTacToe = new TicTacToe();
                ticTacToe.play(menuSelection);
            }
            if(gameChoice == RootMenuSelection.NineMensMorris)
            {
                NineMensMorris nineMenMorris = new NineMensMorris();
                nineMenMorris.Introduction();

            }
            if(gameChoice == RootMenuSelection.Reversi)
            {
                Reversi reversi = new Reversi();
                reversi.Introduction();
            }

            if(gameChoice == RootMenuSelection.HighScores)
            {
                // load high score class
            }

            if(gameChoice == RootMenuSelection.LoadGame)
            {
                // factory can create itself.
                var loadGame = Load.loadGame();
                Console.Write("this is a game loaded :::_" + loadGame);
            }

            if(gameChoice == RootMenuSelection.Quit)
            {
                Environment.Exit(0);
            }

        }


    }
}
