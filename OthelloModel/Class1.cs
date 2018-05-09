using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OthelloModel
{

    public enum GamePiece
    {
        Blank,
        Black,
        White
    }

    public class OthelloGame
    {
        public GamePiece[,] board = new GamePiece[8, 8];

        public OthelloGame()
        {
            for (int row = 0; row < 8; row++)
            for (int column = 0; column < 8; column++)
                board[row, column] = GamePiece.Blank;
            board[3, 4] = board[4, 3] = GamePiece.Black;
            board[3, 3] = board[4, 4] = GamePiece.White;
            CurrentPlayer = GamePiece.Black;
        }

        public bool Move(int row, int col)
        {
            if (board[row, col] != GamePiece.Blank)
                return false;
            board[row, col] = CurrentPlayer;
            return true;
        }

        public GamePiece CurrentPlayer { get; set; }

        public void TogglePlayer()
        {
            if (CurrentPlayer == GamePiece.Blank)
                throw new Exception();
            CurrentPlayer = CurrentPlayer == GamePiece.White ? GamePiece.Black : GamePiece.White;
        }
    }

}
