using System;
namespace IFQ563_Assignment2
{
    public interface IGameState
    {
        public char[] GameBoard { get; set; }
        public string GameName { get; set; }
        public string writeBoardState();
    }
}
