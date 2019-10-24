using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_BLACKJACK
{
    public abstract class BasePlayer:IBlackjackPlajer
    {
        protected string Name { get; set; }
        protected List<Card> Cards { get; set; }

        public BasePlayer()
        {
            Cards = new List<Card>();
            Name = GetName();
        }
        //returns players cards in hand
        public List<Card> GetCards()
        {
            return Cards;
        }
        //counts total points of players cards. If total points are over 21 and player has 'Ace', 
        //remove 10 points for each eice until points are <=21 or there are no more aces
        public int CountPoints()
        {
            int points = Cards.Sum(c => c.GetPoints());

            if (points > 21)
            {
                int aceCount = Cards.Count(c => c.GetPoints() == 11);

                while (aceCount > 0 && points > 21)
                {
                    points -= 10;
                    aceCount--;
                }

            }
            return points;
        }
        //returns true if players points are over 21, otherwise false
        public bool isGameCompleated()
        {
            return CountPoints() >= 21;
        }
        //player receives new card from deck, add it to the deck
        public virtual void GiveCard(Card card)
        {
            Cards.Add(card);
        }

        public abstract string GetName();

        public abstract bool WantCard();

    }
}
