using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_WNF
{
    class GameEngine
    {
        public void StartGame(string [,] TicTacToeBoard)
        {
            var Player = string.Empty;
            var Cpu = string.Empty;

            InitializeBoard(TicTacToeBoard);

            choosePlayers(ref Player, ref Cpu);

            PlayGame(TicTacToeBoard, Player, Cpu);
        }

        private void PlayGame(string[,] ticTacToeBoard, string Player, string Cpu)
        {
            var CheckWinner = String.Empty;
            var CurrentPlayer = Player;

            while (CheckWinner.Equals(string.Empty))
            {
                Console.WriteLine("Enter the position X of {0}", CurrentPlayer);
                int PositionX = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter the position Y of {0}", CurrentPlayer);
                int PositionY = Int32.Parse(Console.ReadLine());

                if (ticTacToeBoard[PositionX, PositionY].Equals(" "))
                    ticTacToeBoard[PositionX, PositionY] = CurrentPlayer;

                PrintTicTacToeBoard(ticTacToeBoard);

                CheckWinner = CheckForVictory(ticTacToeBoard, CurrentPlayer);

                CurrentPlayer = CurrentPlayer.Equals(Player) ? Cpu : Player;
            }
        }

        private void PrintTicTacToeBoard(string[,] ticTacToeBoard)
        {
            for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ticTacToeBoard.GetLength(0); j++)
                {
                    Console.WriteLine(ticTacToeBoard[i, j] + " ");
                }
            }
        }

        private string CheckForVictory(string[,] ticTacToeBoard, string currentPlayer)
        {
            
        }

        private void choosePlayers(ref string Player, ref string Cpu)
        {
            Console.WriteLine("Player, Do you want to be X or O ?");

            while (true)
            {
                Player = Console.ReadLine().ToUpper();

                if (Player.ToUpper().Equals("X") || Player.ToUpper().Equals("O"))
                    break;
            }

            Cpu = Player.ToUpper().Equals("X") ? "O" : "X";

        }

        private void InitializeBoard(string[,] ticTacToeBoard)
        {
            for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ticTacToeBoard.GetLength(0); j++)
                {
                    ticTacToeBoard[i, j] = " ";
                }
            }
        }
    }
}
