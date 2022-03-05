using System;
namespace IFQ563_Assignment2
{
    public interface IGameFactory
    {
      public void CreateGame(RootMenuSelection gameChoice);
    }
}
