using System;
namespace IFQ563_Assignment2
{
    public interface GameInterface
    {

        public abstract int Introduction();

        public void GameSelector(int gameSelected);

        public abstract void DrawBoard(char[] board);
    }
}
