using ConsoleHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_BLACKJACK
{
    public class Player:BasePlayer
    {
        public override string GetName()
        {
            //If players name is defined return it, otherwise ask for users name
            if (!String.IsNullOrEmpty(Name))
            {
                return Name;
            }
            return ConsoleInput.GetText("Enter Your name: ");
        }
        public override bool WantCard()
        {
            return ConsoleInput.GetBool("Another card? ");
        }
        public override void GiveCard(Card card)
        {
            base.GiveCard(card);

            Console.WriteLine($"You received card: {card.GetTitle()}");
            Console.WriteLine($"Your points: {CountPoints()}");
        }
    }
}
