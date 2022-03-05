using System;
using System.IO;
using System.Threading.Tasks;
namespace IFQ563_Assignment2
{
        public class Save
        {
        public static async Task SaveInProgressToFile(char[] board, string gameName, bool isNewGame)
        {
            var gameState = new GameState { GameBoard = board, GameName = gameName, IsNewGame = isNewGame };
            //using StreamWriter file = new StreamWriter("savedGames.txt", append: true);
            //await file.WriteLineAsync(gameState.writeBoardState());
            Console.Write(gameState);
            Console.Write("this is game state");

           
        }
    }
}
