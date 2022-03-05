using System;
namespace IFQ563_Assignment2
{
    public class Game 
    {

      public void Play()
        {
            Menu rootMenu = new Menu();
            RootMenuSelection rootMenuSelection = rootMenu.RootMenu();
            GameFactory gameFactory = new GameFactory();
            gameFactory.CreateGame(rootMenuSelection);
        }
    }
}
