using System;
using System.Threading;

namespace IFQ563_Assignment2

{
    public class TicTacToe
    {
        static char[] arr =  new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int choice;
        static int player = 1;
        int gameState = 2;
        bool newGame = true;

        static int flag = 0;
        public void introduction()
        {
            Console.WriteLine("Welcome to Tic Tac Toe.");
        }

        public void play(SubMenuGame gameSelection)
        {
            Console.Write(gameSelection);
            if (gameSelection == SubMenuGame.LoadGame)
            {
                string loadGame = Load.loadGame("TicTacToe");
                Console.Write("this is a game faggot_" + loadGame);
                arr = loadGame.ToCharArray();
                DrawBoard();
                gameLoop();
            }

            if (gameSelection == SubMenuGame.HumanVsHuman)

            {
                DrawBoard();
                gameLoop();
            }

            if (gameSelection == SubMenuGame.Quit)
            {
                Game game = new Game();
                game.play();
            }
        }


        public async void gameLoop()
        {
            //while (choice < 12)
            do
            {
                //Console.Clear();
                //Console.Write("enter heeere:");
                Console.Clear();// whenever loop will be again start then screen will be clear
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");
                DrawBoard();

                choice = getInput();

                if (choice == 10)
                {

                    PreviousGame loadGame = Load.loadPreviousGame(gameState, "TicTacToe");

                    // undo only inside this game. 
                    if (!loadGame.isNew)
                    {
                        gameState++;
                    }


                    arr = loadGame.gameboard.ToCharArray();
                    choice = getInput();
                }

                if (choice == 11)
                {
                    PreviousGame loadGame = Load.loadPreviousGame(gameState, "TicTacToe");

                    // undo only inside this game. 
                    if (gameState > 2)
                    {
                        gameState--;
                    }

                    arr = loadGame.gameboard.ToCharArray();
                    choice = getInput();
                }


                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                    await Save.SaveInProgressToFile(arr, "TicTacToe", newGame);
                    newGame = false;
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                }

                flag = CheckWin();// calling of check win

                Console.WriteLine("Left Arrow to Undo and Right Arrow to Undo\n");
                Console.WriteLine("ESC to end game");


          
            }
            while (flag != 1 && flag != -1);
            Console.Clear();
            DrawBoard();   
            if (flag == 1)
            // if flag value is 1 then someone has win or
            //means who played marked last time which has win
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else// if flag value is -1 the match will be draw and no one is winner
            {
                Console.WriteLine("Draw");
            }
            Console.Write("Press Enter to Play Again");
            Console.ReadLine();

            //Game game = new Game();
            //game.play();

            GameFactory gameFactory = new GameFactory();
            gameFactory.CreateGame(RootMenuSelection.TicTacToe);

        }





        private int getInput()
        {

            ConsoleKeyInfo enteredKey = Console.ReadKey();
            switch(enteredKey.Key)
            {
                case ConsoleKey.D0:
                    return 0;
                case ConsoleKey.D1:
                    return 1;
                case ConsoleKey.D2:
                    return 2;
                case ConsoleKey.D3:
                    return 3;
                case ConsoleKey.D4:
                    return 4;
                case ConsoleKey.D5:
                    return 5;
                case ConsoleKey.D6:
                    return 6;
                case ConsoleKey.D7:
                    return 7;
                case ConsoleKey.D8:
                    return 8;
                case ConsoleKey.D9:
                    return 9;
                case ConsoleKey.LeftArrow:
                    return 10;
                case ConsoleKey.RightArrow:
                    return 11;
                case ConsoleKey.Escape:
                    return 12;
            }
            return 10;
        }


        public void DrawBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }



        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
    }
}
