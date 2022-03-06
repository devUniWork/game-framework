using System;
namespace IFQ563_Assignment2
{
    public interface IGameInterface
    {
        public void Play();
    }

    public class Game : IGameInterface
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
