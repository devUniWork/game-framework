using System;
using System.Collections.Generic;
namespace IFQ563_Assignment2
{
    public class Player
    {
		// empty this list each time.

        public virtual char[] EasyMode(char[] board)
        {
			List<char> chars = new List<char> { };
			for (int i = 0; i < board.Length; i++)
			{
				if (board[i] != 'O' && board[i] != 'X')
				{
					chars.Add(board[i]);
				}
			}
				Random rnd = new Random();
				int val = chars.Count - 1;
				int computerTurn = rnd.Next(0, val);
				int newPos = (int)Char.GetNumericValue(chars[computerTurn]);
			board[newPos] = 'O';

			return board;
        }

        public virtual char[] HardMode(char[] board)
        {
            return board;
        }
    }
}
