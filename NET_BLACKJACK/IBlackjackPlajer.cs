using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_BLACKJACK
{
    public interface IBlackjackPlajer
    {
        //Returns player's name
        string GetName();
        //Returns players cards in hand
        List<Card> GetCards();
        //Counts total points of players cards
        int CountPoints();
        //Checks if players points are over 21
        bool isGameCompleated();
        //Checks if player wants another card
        bool WantCard();
        //Player receives new card from deck. Adds card to players deck
        void GiveCard(Card card);
    } 
}
