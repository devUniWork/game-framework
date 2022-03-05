using System;
namespace IFQ563_Assignment2
{
    public interface IPiece
    {
        public abstract int GetNewPosition();
        public abstract int CheckWin(char[] arr);
    }
}
