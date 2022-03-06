using System;
namespace IFQ563_Assignment2
{
    public interface IGame
    {
        static char[] board;
        static int choice;
        static int player;
        static int gameState;
        static bool newGame;
        static int flag = 0;
        static Piece piece;
        static Draw draw;
        static AI ai;
        public void Introduction();
        public void Play(SubMenuGame gameSelection);
        public void GameLoop();
        public void GameOver();
    }
}