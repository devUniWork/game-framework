using System;
using System.Threading;

namespace IFQ563_Assignment2

{
    public class TicTacToe : IGame
    {
        static char[] board =  new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int choice;
        static int player = 1;
        int gameState = 2;
        bool newGame = true;
        static int flag = 0;

        Piece piece = new Piece();
        Draw draw = new Draw();

        public void Introduction()
        {
            Console.WriteLine("Welcome to Tic Tac Toe.");
        }

        public void Play(SubMenuGame gameSelection)
        {
            Console.Write(gameSelection);
            if (gameSelection == SubMenuGame.LoadGame)
            {
                string loadGame = Load.loadGame("TicTacToe");
                char[] board = loadGame.ToCharArray();
                draw.DrawBoard(board);
                GameLoop();
            }

            if (gameSelection == SubMenuGame.HumanVsHuman)

            {
                draw.DrawBoard(board);
                GameLoop();
            }

            if(gameSelection == SubMenuGame.Rules)
            {
                Documentation docs = new Documentation();
                docs.Rules("Hello and Welcome to TicTacToe\n" +
                           "This is a two player, or one player & a computer - grid based game\n" +
                           "Player1: X token and Player2: O token\n" +
                           "You as a Human will always be Player 1.\n" +
                           "To play:\n" +
                           "Please enter the corresponding grid number on your numpad\n" +
                           "Then press enter\n" +
                           "To win ne the first to have a full horizontal," +
                           "vertical or diagonal line of your token\n"
               );
               GameFactory gameFactory = new GameFactory();
               gameFactory.CreateGame(RootMenuSelection.TicTacToe);

            }

            if (gameSelection == SubMenuGame.Quit)
            {
                Game game = new Game();
                game.Play();
            }
        }


        public async void GameLoop()
        {
            //while (choice < 12)
            do
            {
                Console.Clear();
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");
                draw.DrawBoard(board);

                choice = piece.GetNewPosition();

                if (choice == 10)
                {

                    PreviousGame loadGame = Load.loadPreviousGame(gameState, "TicTacToe");

                    // undo only inside this game. 
                    if (!loadGame.isNew)
                    {
                        gameState++;
                    }
                   
                    board = loadGame.gameboard.ToCharArray();
                    choice = piece.GetNewPosition();
                }

                if (choice == 11)
                {
                    PreviousGame loadGame = Load.loadPreviousGame(gameState, "TicTacToe");

                    // undo only inside this game. 
                    if (gameState > 2)
                    {
                        gameState--;
                    }

                    board = loadGame.gameboard.ToCharArray();
                    choice = piece.GetNewPosition();
                }



                if (board[choice] != 'X' && board[choice] != 'O')
                {
                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X
                    {
                        board[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        board[choice] = 'X';
                        player++;
                    }
                    await Save.SaveInProgressToFile(board, "TicTacToe", newGame);
                    newGame = false;
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, board[choice]);
                }

                flag = piece.CheckWin(board);// calling of check win

                Console.WriteLine("Left Arrow to Undo and Right Arrow to Undo\n");
                Console.WriteLine("ESC to end game");
            }
            while (flag != 1 && flag != -1);
            draw.ClearBoard();
            draw.DrawBoard(board);
            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else// if flag value is -1 the match will be draw and no one is winner
            {
                Console.WriteLine("Draw");
            }

            GameOver();
        }

        public void GameOver()
        {
            Console.Write("Press Enter to Play Again");
            Console.ReadLine();
            GameFactory gameFactory = new GameFactory();
            gameFactory.CreateGame(RootMenuSelection.TicTacToe);
        }
    }
}
