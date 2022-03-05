using System;
namespace IFQ563_Assignment2
{
    public class GameState : IGameState
    {
        public char[] GameBoard { get; set; }
        public string GameName { get; set; }
        public bool IsNewGame { get; set; }
        //public string GameName { get; set; }

        public string writeBoardState()
        {
            return GameName + "~" + (DateTime.Now.ToString() + "-") + new string(GameBoard) + "+" + IsNewGame.ToString();
        }
    }
}
