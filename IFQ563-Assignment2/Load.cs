using System;
using System.IO;
using System.Linq;
namespace IFQ563_Assignment2
{
    public interface IPreviousGame {
        public string gameboard { get; set; }
        public bool isNew { get; set; }
    }

    public class PreviousGame : IPreviousGame {
        public string gameboard { get; set; }
        public bool isNew { get; set; }
    }

    public class Load
    {
        public Load()
        {
        }
#nullable enable
        public static string loadGame(string? gameName = null)
        {
#nullable disable
            string[] lines = File.ReadAllLines("savedGames.txt");
            var index = 0;
            Console.Write(gameName);
            if(gameName != null)
            {
                lines = lines.Where(c => c.Split("~")[0] == gameName).ToArray();
            }

            Console.Write("Select The Game State You Would Like to Load In \n");
            foreach (var line in lines)
            {
                Console.WriteLine("\t" + "Type: " + index.ToString() + " to select this game state: - " + line);
                index++;
            }
            return lines[Convert.ToInt32(Console.ReadLine())].Split("-")[1];
        }
#nullable enable
        public static PreviousGame loadPreviousGame(int gameState, string? gameName = null)
        {
#nullable disable
            string[] lines = File.ReadAllLines("savedGames.txt");
            var index = 0;
            Console.Write(gameName);
            if (gameName != null)
            {
                Console.Write(lines[lines.Length - gameState].Split("-")[1]);
                lines = lines.Where(c => c.Split("~")[0] == gameName).ToArray();
            }
        
            return new PreviousGame { gameboard = lines[lines.Length - gameState].Split("-")[1], isNew = bool.Parse(lines[lines.Length - gameState].Split("+")[1]) };
        }

    }
}
