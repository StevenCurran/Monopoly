using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trolopoloy
{
    class CardPile
    {
        public CardPile(String name, List<Card> cards)
        {
            this.name = name;
            this.cards = cards;
        }

        public void Shuffle()
        {
            for(int i = 1 ; i < cards.Count - 1; i++)
            {
                Random rand = new Random(); 
                
                int dest = rand.Next(0, i);
                Card temp = cards[dest];

                cards[dest] = cards[i];
                cards[i] = temp;
            }
        }
 
        public Card GetNextCard()
        {
            Card nextCard = cards[0];
            cards.RemoveAt(0);
            cards.Add(nextCard);
            return nextCard;
        }

        private String name;
        private List<Card> cards;
    }
}
