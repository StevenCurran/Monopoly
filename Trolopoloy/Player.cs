using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trolopoloy
{
    
    class Player : Trader
    {
        public Player(String name, Board.TraderID id) : base(name, id)
        {
            doublesInARow = 0;
            positionOnBoard = 0;
            InJail = false;
            getOutOfJailFreeCards = 0;
        }

        public Roll RollDice(Dice theDice)
        {
            Roll roll = theDice.Roll();

            if(roll.Double)
            {
                doublesInARow++;
                InJail = false;
                if(doublesInARow >= 3)
                {
                    InJail = true;
                }
            }

            if (!InJail)
            {
                MoveRelative(roll.Move);
            }

            return roll;
        }

        public void MoveAbsolute(int squareToWhichToMove)
        {
            int oldSquare = positionOnBoard;
            positionOnBoard = squareToWhichToMove;
            if(positionOnBoard < oldSquare)
            {
                Board.PassGo(this);
            }
        }

        public void MoveRelative(int squaresToMove)
        {
            positionOnBoard += squaresToMove;

            if(positionOnBoard > Board.SquaresOnBoard)
            {
                positionOnBoard %= Board.SquaresOnBoard;
                Board.PassGo(this);
            }
        }

        public void PayBail(Trader theBanker)
        {
            if (getOutOfJailFreeCards > 0)
            {
                getOutOfJailFreeCards--;
                InJail = false;
            }
            else
            {
                this.TransferMoney(theBanker, 50);
            }
        }

        public void AssignPiece(PlayerPiece piece)
        {
            this.piece = piece;
        }

        public bool InJail
        {
            get
            {
                return inJail;
            }

            set
            {
                inJail = value;
                if(inJail)
                {
                    positionOnBoard = Board.JailSquare;
                }
            }
        }

        private PlayerPiece piece;
        private int getOutOfJailFreeCards;
        private int doublesInARow;
        private int positionOnBoard;
        private bool inJail;
    }
}
