using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trolopoloy
{
    class Board
    {
        private Square[] squares;
        private CardPile chanceCards;
        private CardPile communityChestCards;
        private Player activePlayer;
        private Player[] players;
        private PlayerPiece[] pieces;

        public static Trader Banker;
        public static int SquaresOnBoard = 40;
        public static int JailSquare = 10;
        public static int GoSquare = 0;

        public enum TraderID
        {
            Banker,
            Player1,
            Player2,
            Player3,
            Player4
        } ;

        public Board()
        {
            squares = new Square[SquaresOnBoard];

            // Place the corner squares (GO, Jail etc)
            for (int i = 0; i < SquaresOnBoard - 1; i += 10)
            {
                squares[i] = new ActionSquare();
            }

            // Place the card squares.
            squares[2] = new CardSquare();
            squares[7] = new CardSquare();
            squares[17] = new CardSquare();
            squares[22] = new CardSquare();
            squares[33] = new CardSquare();
            squares[36] = new CardSquare();

            // Place the station squares.
            squares[5] = new StationSquare();
            squares[15] = new StationSquare();
            squares[25] = new StationSquare();
            squares[35] = new StationSquare();

            // Place the utility squares.
            squares[12] = new UtilitySquare();
            squares[28] = new UtilitySquare();
            
            // Place the tax squares.
            squares[4] = new ActionSquare();
            squares[38] = new ActionSquare();

            for (int i = 0; i < SquaresOnBoard; i++)
            {
                if(squares[i] == null)
                {
                    squares[i] = new StreetSquare();
                }
            }
        }

        public static void PassGo(Player dest)
        {
            Banker.TransferMoney(dest, 200);
        }
    }
}
