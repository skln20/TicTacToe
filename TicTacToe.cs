using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class TicTacToe
    {
        public static void OutputState(char[,] state)
        {
            int Ocount = 0;
            int Xcount = 0;

            for (int i = 0; i < state.GetLength(0); i++) //2
            {
                for(int j=0; j < state.GetLength(1); j++) //2
                {
                    char ch = state[i, j];
                    switch (ch)
                    {
                        case 'O':
                            Ocount++;
                            break;
                        case 'X':
                            Xcount++;
                            break;
                    }
                }
            }

            //invalid input
            if(Ocount > Xcount || (Xcount - Ocount) > 1 || winningCombinationX(state) && winningCombinationY(state) ||
                winningCombinationY(state) && Xcount > Ocount)
            {
                Console.WriteLine("Wait, what?");
                return;
            }

            //X won
            if (winningCombinationX(state))
            {
                Console.WriteLine("X won.");
                return;
            }

            //Y won
            if (winningCombinationY(state))
            {
                Console.WriteLine("O won.");
                return;
            }

            //draw
            if (Xcount == 5 && Ocount == 4)
            {
                Console.WriteLine("It is a draw.");
                return;
            }

            //turn
            if (Xcount == Ocount)
            {
                Console.WriteLine("X's turn");
            }
            else if (Xcount - Ocount == 1)
            {
                Console.WriteLine("O's turn");
            }
        }

        private static bool winningCombinationX(char[,] state)
        {
            if(state[0, 0] == 'X' && state[0, 1] == 'X' && state[0, 2] == 'X' ||
               state[1, 0] == 'X' && state[1, 1] == 'X' && state[1, 2] == 'X' ||
               state[2, 0] == 'X' && state[2, 1] == 'X' && state[2, 2] == 'X' ||
               state[0, 0] == 'X' && state[1, 0] == 'X' && state[2, 0] == 'X' ||
               state[0, 1] == 'X' && state[1, 1] == 'X' && state[2, 1] == 'X' ||
               state[0, 2] == 'X' && state[1, 2] == 'X' && state[2, 2] == 'X' ||
               state[0, 0] == 'X' && state[1, 1] == 'X' && state[2, 2] == 'X' ||
               state[0, 2] == 'X' && state[1, 1] == 'X' && state[2, 0] == 'X')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool winningCombinationY(char[,] state)
        {
            if (state[0, 0] == 'O' && state[0, 1] == 'O' && state[0, 2] == 'O' ||
               state[1, 0] == 'O' && state[1, 1] == 'O' && state[1, 2] == 'O' ||
               state[2, 0] == 'O' && state[2, 1] == 'O' && state[2, 2] == 'O' ||
               state[0, 0] == 'O' && state[1, 0] == 'O' && state[2, 0] == 'O' ||
               state[0, 1] == 'O' && state[1, 1] == 'O' && state[2, 1] == 'O' ||
               state[0, 2] == 'O' && state[1, 2] == 'O' && state[2, 2] == 'O' ||
               state[0, 0] == 'O' && state[1, 1] == 'O' && state[2, 2] == 'O' ||
               state[0, 2] == 'O' && state[1, 1] == 'O' && state[2, 0] == 'O')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
