using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] state1 =
            {
                { 'O', '.', 'X' },
                { '.', '.', 'X' },
                { '.', '.', 'X' }
            };
            TicTacToe.OutputState(state1);

            char[,] state2 =
            {
                { '.', 'O', '.' },
                { '.', 'O', 'X' },
                { '.', 'O', 'X' }
            };
            TicTacToe.OutputState(state2);

            char[,] state3 =
            {
                { '.', 'O', 'X' },
                { '.', 'O', 'X' },
                { '.', 'O', 'X' }
            };
            TicTacToe.OutputState(state3);

            char[,] state4 =
            {
                { 'O', '.', 'X' },
                { '.', 'O', 'X' },
                { 'X', '.', 'O' }
            };
            TicTacToe.OutputState(state4);

            char[,] state5 =
            {
                { 'O', '.', 'X' },
                { '.', 'O', 'X' },
                { 'X', 'O', '.' }
            };
            TicTacToe.OutputState(state5);

            char[,] state6 =
            {
                { 'X', 'O', 'X' },
                { '.', 'O', 'X' },
                { 'X', 'O', '.' }
            };
            TicTacToe.OutputState(state6);

            char[,] state7 =
            {
                { 'O', '.', 'X' },
                { '.', 'X', 'O' },
                { 'X', 'O', 'X' }
            };
            TicTacToe.OutputState(state7);

            char[,] state8 =
            {
                { 'O', 'X', 'X' },
                { '.', 'O', 'X' },
                { 'X', 'O', '.' }
            };
            TicTacToe.OutputState(state8);

            char[,] state9 =
            {
                { 'O', 'O', 'X' },
                { 'X', 'X', 'O' },
                { 'O', 'X', 'X' }
            };
            TicTacToe.OutputState(state9);
        }
    }
}
