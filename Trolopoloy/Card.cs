using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trolopoloy
{
    class Card
    {
        private String name;
        private String description;
        private CardType cardType;
        private int value;

        public enum CardType
        {
            Tax,
            Reward,
            MoveRelative,
            MoveAbsolute
        } ;
        
        public Card(String name, String description, CardType cardType, int value)
        {
            this.name = name;
            this.description = description;
            this.cardType = cardType;
            this.value = value;
        }

        public void performAction(Player player)
        {
            switch (cardType)
            {
                case CardType.Tax: player.TransferMoney(Board.Banker, value);
                    break;
                case CardType.Reward: Board.Banker.TransferMoney(player, value);
                    break;
                case CardType.MoveRelative: player.MoveRelative(value);
                    break;
                case CardType.MoveAbsolute: player.MoveAbsolute(value);
                    break;
            }
        }
    }
}
